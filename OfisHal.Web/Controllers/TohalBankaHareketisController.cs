using OfisHal.Core.Domain;
using OfisHal.Data.Context;
using System.Collections.Generic;
using System.Data;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace OfisHal.Web.Controllers
{
    public class TohalBankaHareketisController : BaseController
    {
        private readonly Db _context;

        public TohalBankaHareketisController(Db context)
        {
            _context = context;
        }

        // GET: TohalBankaHareketis
        public async Task<ActionResult> Index()
        {
            var Db = _context.TohalBankaHareketis.Include(t => t.BankaHesabi).Include(t => t.CariKart).Include(t => t.Ekleyen).Include(t => t.Guncelleyen).Include(t => t.Hesap).Include(t => t.KarsiBankaHesabi).Include(t => t.PosCihazi);
            return View(await Db.ToListAsync());
        }

        // GET: TohalBankaHareketis/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null || _context.TohalBankaHareketis == null)
            {
                return HttpNotFound();
            }

            var tohalBankaHareketi = await _context.TohalBankaHareketis
                .Include(t => t.BankaHesabi)
                .Include(t => t.CariKart)
                .Include(t => t.Ekleyen)
                .Include(t => t.Guncelleyen)
                .Include(t => t.Hesap)
                .Include(t => t.KarsiBankaHesabi)
                .Include(t => t.PosCihazi)
                .FirstOrDefaultAsync(m => m.BankaHareketiId == id);
            if (tohalBankaHareketi == null)
            {
                return HttpNotFound();
            }

            return View(tohalBankaHareketi);
        }

        // GET: TohalBankaHareketis/Create
        public ActionResult Create()
        {
            ViewData["PosCihaziId"] = new SelectList(_context.TohalPosCihazis, "PosCihaziId", "Ad");
            return View();
        }

        // POST: TohalBankaHareketis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "BankaHareketiId,BankaHesabiId,Tarih,IslemTipi,Aciklama,Meblag,CariKartId,EkleyenId,EklemeZamani,GuncelleyenId,GuncellemeZamani,HesapId,KarsiBankaHesabiId,PosCihaziId")] TohalBankaHareketi tohalBankaHareketi)
        {
            if (ModelState.IsValid)
            {
                var parameters = new List<SqlParameter>
                {
                    new SqlParameter("@BANKA_HAREKETI_ID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output,
                    },
                    new SqlParameter("@BANKA_HESABI_ID", (object)tohalBankaHareketi.BankaHesabiId ?? DBNull.Value),
                    new SqlParameter("@TARIH", (object)tohalBankaHareketi.Tarih ?? DBNull.Value),
                    new SqlParameter("@ACIKLAMA", (object)tohalBankaHareketi.Aciklama ?? DBNull.Value),
                    new SqlParameter("@MEBLAG", (object)tohalBankaHareketi.Meblag ?? DBNull.Value),
                    new SqlParameter("@ISLEM_TIPI", (object)tohalBankaHareketi.IslemTipi ?? DBNull.Value),
                    new SqlParameter("@CARI_KART_ID", (object)tohalBankaHareketi.CariKartId ?? DBNull.Value),
                    new SqlParameter("@HESAP_ID", (object)tohalBankaHareketi.HesapId ?? DBNull.Value),
                    new SqlParameter("@KARSI_BANKA_HESABI_ID", (object)tohalBankaHareketi.KarsiBankaHesabiId ?? DBNull.Value),
                    new SqlParameter("@POS_CIHAZI_ID", (object)tohalBankaHareketi.PosCihaziId ?? DBNull.Value),
                    new SqlParameter("@KULLANICI_ID", 3),
                    new SqlParameter("@DEGISIKLIK_TAKIP_VAR", 1),
                };
                await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_BANKA_HAREKETI_KAYDET @BANKA_HAREKETI_ID OUTPUT, @BANKA_HESABI_ID, @TARIH, @ACIKLAMA, @MEBLAG, @ISLEM_TIPI, @CARI_KART_ID, @HESAP_ID, @KARSI_BANKA_HESABI_ID, @POS_CIHAZI_ID, @KULLANICI_ID, @DEGISIKLIK_TAKIP_VAR", parameters.ToArray());
                return RedirectToAction(nameof(Create));
            }
            ViewData["PosCihaziId"] = new SelectList(_context.TohalPosCihazis, "PosCihaziId", "Ad", tohalBankaHareketi.PosCihaziId);
            return View(tohalBankaHareketi);
        }

        // GET: TohalBankaHareketis/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null || _context.TohalBankaHareketis == null)
            {
                return HttpNotFound();
            }

            var tohalBankaHareketi = await _context.TohalBankaHareketis.Include(x => x.BankaHesabi).Include(x => x.CariKart).Include(x => x.Hesap).Include(x => x.KarsiBankaHesabi).Include(x => x.PosCihazi).FirstOrDefaultAsync(x => x.BankaHareketiId == id);
            if (tohalBankaHareketi == null)
            {
                return HttpNotFound();
            }
            ViewData["PosCihaziId"] = new SelectList(_context.TohalPosCihazis, "PosCihaziId", "Ad", tohalBankaHareketi.PosCihaziId);
            return View(tohalBankaHareketi);
        }

        // POST: TohalBankaHareketis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, [Bind(Include = "BankaHareketiId,BankaHesabiId,Tarih,IslemTipi,Aciklama,Meblag,CariKartId,EkleyenId,EklemeZamani,GuncelleyenId,GuncellemeZamani,HesapId,KarsiBankaHesabiId,PosCihaziId")] TohalBankaHareketi tohalBankaHareketi)
        {
            if (id != tohalBankaHareketi.BankaHareketiId)
            {
                return HttpNotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Entry(tohalBankaHareketi).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TohalBankaHareketiExists(tohalBankaHareketi.BankaHareketiId))
                    {
                        return HttpNotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["PosCihaziId"] = new SelectList(_context.TohalPosCihazis, "PosCihaziId", "Ad", tohalBankaHareketi.PosCihaziId);
            return View(tohalBankaHareketi);
        }

        // GET: TohalBankaHareketis/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null || _context.TohalBankaHareketis == null)
            {
                return HttpNotFound();
            }

            var tohalBankaHareketi = await _context.TohalBankaHareketis
                .Include(t => t.BankaHesabi)
                .Include(t => t.CariKart)
                .Include(t => t.Ekleyen)
                .Include(t => t.Guncelleyen)
                .Include(t => t.Hesap)
                .Include(t => t.KarsiBankaHesabi)
                .Include(t => t.PosCihazi)
                .FirstOrDefaultAsync(m => m.BankaHareketiId == id);
            if (tohalBankaHareketi == null)
            {
                return HttpNotFound();
            }

            return View(tohalBankaHareketi);
        }

        // POST: TohalBankaHareketis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            if (_context.TohalBankaHareketis == null)
            {
                return Problem("Entity set 'Db.TohalBankaHareketis'  is null.");
            }
            var tohalBankaHareketi = await _context.TohalBankaHareketis.FindAsync(id);
            if (tohalBankaHareketi != null)
            {
                _context.TohalBankaHareketis.Remove(tohalBankaHareketi);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TohalBankaHareketiExists(int id)
        {
            return _context.TohalBankaHareketis.Any(e => e.BankaHareketiId == id);
        }

        public ActionResult ilkSonKayit(bool firstOrLast)
        {
            var val = firstOrLast ? _context.TohalBankaHareketis.FirstOrDefault() : _context.TohalBankaHareketis.OrderByDescending(x => x.BankaHareketiId).FirstOrDefault();
            return val != null ? RedirectToAction("Edit", new { id = val.BankaHareketiId }) : RedirectToAction("Edit");
        }
        public ActionResult sonrakiOncekiKayit(bool afterOrBefore, int currentId)
        {
            var val = afterOrBefore ? _context.TohalBankaHareketis.Where(x => x.BankaHareketiId > currentId).FirstOrDefault() : _context.TohalBankaHareketis.OrderByDescending(x => x.BankaHareketiId).Where(x => x.BankaHareketiId < currentId).FirstOrDefault();
            if (val == null)
                return RedirectToAction("ilkSonKayit", new { firstOrlast = !afterOrBefore });
            return RedirectToAction("Edit", new { id = val.BankaHareketiId });
        }
    }
}
