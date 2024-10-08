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
using System.Data.Common;

namespace OfisHal.Web.Controllers
{
    public class TohalBankaHesabisController : BaseController
    {
        private readonly Db _context;

        public TohalBankaHesabisController(Db context)
        {
            _context = context;
        }

        // GET: TohalBankaHesabis
        public async Task<ActionResult> Index()
        {
            var Db = _context.TohalBankaHesabis.Include(t => t.Banka).Include(t => t.MuhHesap);
            return View(await Db.ToListAsync());
        }

        // GET: TohalBankaHesabis/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null || _context.TohalBankaHesabis == null)
            {
                return HttpNotFound();
            }

            var tohalBankaHesabi = await _context.TohalBankaHesabis
                .Include(t => t.Banka)
                .Include(t => t.MuhHesap)
                .FirstOrDefaultAsync(m => m.BankaHesabiId == id);
            if (tohalBankaHesabi == null)
            {
                return HttpNotFound();
            }

            return View(tohalBankaHesabi);
        }

        // GET: TohalBankaHesabis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TohalBankaHesabis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "BankaHesabiId,HesapNo,HesapAdi,Iban,SubeAdi,BankaId,Devir,MuhHesapId,EFaturadaGozuksun")] TohalBankaHesabi tohalBankaHesabi)
        {
            if (ModelState.IsValid)
            {
                var parameters = new List<SqlParameter>
                {
                    new SqlParameter("@BANKA_HESABI_ID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output,
                    },
                    new SqlParameter("@HESAP_NO", (object)tohalBankaHesabi.HesapNo ?? DBNull.Value),
                    new SqlParameter("@HESAP_ADI", (object)tohalBankaHesabi.HesapAdi ?? DBNull.Value),
                    new SqlParameter("@IBAN", (object)tohalBankaHesabi.Iban ?? DBNull.Value),
                    new SqlParameter("@SUBE_ADI", (object)tohalBankaHesabi.SubeAdi ?? DBNull.Value),
                    new SqlParameter("@BANKA_ID", (object)tohalBankaHesabi.BankaId ?? DBNull.Value),
                    new SqlParameter("@DEVIR", (object)tohalBankaHesabi.Devir ?? DBNull.Value),
                    new SqlParameter("@MUH_HESAP_ID", (object)tohalBankaHesabi.MuhHesapId ?? DBNull.Value),
                    new SqlParameter("@E_FATURADA_GOZUKSUN", (object)tohalBankaHesabi.EFaturadaGozuksun ?? DBNull.Value),
                };
                await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_BANKA_HESABI_KAYDET @BANKA_HESABI_ID OUTPUT, @HESAP_NO, @HESAP_ADI, @IBAN, @SUBE_ADI, @BANKA_ID, @DEVIR, @MUH_HESAP_ID,@E_FATURADA_GOZUKSUN", parameters.ToArray());
                return RedirectToAction(nameof(Create));
            }
            return View(tohalBankaHesabi);
        }

        // GET: TohalBankaHesabis/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null || _context.TohalBankaHesabis == null)
            {
                return HttpNotFound();
            }

            var tohalBankaHesabi = await _context.VohalBankaHesabis.FindAsync(id);
            if (tohalBankaHesabi == null)
            {
                return HttpNotFound();
            }
            return View(tohalBankaHesabi);
        }

        // POST: TohalBankaHesabis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, [Bind(Include = "BankaHesabiId,HesapNo,HesapAdi,Iban,SubeAdi,BankaId,Devir,MuhHesapId,EFaturadaGozuksun")] VohalBankaHesabi tohalBankaHesabi)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var parameters = new List<SqlParameter>();

                    if (tohalBankaHesabi.BankaHesabiId == 0)
                    {
                        parameters.Add(new SqlParameter("@BANKA_HESABI_ID", SqlDbType.Int) { Direction = ParameterDirection.Output });
                    }
                    else
                    {
                        parameters.Add(new SqlParameter("@BANKA_HESABI_ID", SqlDbType.Int)
                        {
                            Value = tohalBankaHesabi.BankaHesabiId,
                            Direction = ParameterDirection.InputOutput
                        });
                    }

                    parameters.Add(new SqlParameter("@HESAP_NO", (object)tohalBankaHesabi.HesapNo ?? DBNull.Value));
                    parameters.Add(new SqlParameter("@HESAP_ADI", (object)tohalBankaHesabi.HesapAdi ?? DBNull.Value));
                    parameters.Add(new SqlParameter("@IBAN", (object)tohalBankaHesabi.Iban ?? DBNull.Value));
                    parameters.Add(new SqlParameter("@SUBE_ADI", (object)tohalBankaHesabi.SubeAdi ?? DBNull.Value));
                    parameters.Add(new SqlParameter("@BANKA_ID", (object)tohalBankaHesabi.BankaId ?? DBNull.Value));
                    parameters.Add(new SqlParameter("@DEVIR", (object)tohalBankaHesabi.Devir ?? DBNull.Value));
                    parameters.Add(new SqlParameter("@MUH_HESAP_ID", (object)tohalBankaHesabi.MuhHesapId ?? DBNull.Value));
                    parameters.Add(new SqlParameter("@E_FATURADA_GOZUKSUN", (object)tohalBankaHesabi.EFaturadaGozuksun ?? DBNull.Value));

                    await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_BANKA_HESABI_KAYDET @BANKA_HESABI_ID OUTPUT, @HESAP_NO, @HESAP_ADI, @IBAN, @SUBE_ADI, @BANKA_ID, @DEVIR, @MUH_HESAP_ID,@E_FATURADA_GOZUKSUN", parameters.ToArray());

                }
                catch (Exception ex)
                {
                    var hata = ex.Message;
                    throw;
                }
                return RedirectToAction(nameof(Edit), new { id = tohalBankaHesabi.BankaHesabiId });
            }
            return View(tohalBankaHesabi);
        }

        // GET: TohalBankaHesabis/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null || _context.TohalBankaHesabis == null)
            {
                return HttpNotFound();
            }

            var tohalBankaHesabi = await _context.TohalBankaHesabis
                .Include(t => t.Banka)
                .Include(t => t.MuhHesap)
                .FirstOrDefaultAsync(m => m.BankaHesabiId == id);
            if (tohalBankaHesabi == null)
            {
                return HttpNotFound();
            }

            return View(tohalBankaHesabi);
        }

        // POST: TohalBankaHesabis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            if (_context.TohalBankaHesabis == null)
            {
                return Problem("Entity set 'Db.TohalBankaHesabis'  is null.");
            }
            var tohalBankaHesabi = await _context.TohalBankaHesabis.FindAsync(id);
            if (tohalBankaHesabi != null)
            {
                _context.TohalBankaHesabis.Remove(tohalBankaHesabi);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TohalBankaHesabiExists(int id)
        {
            return _context.TohalBankaHesabis.Any(e => e.BankaHesabiId == id);
        }

        public ActionResult ilkSonKayit(bool firstOrLast)
        {
            var val = firstOrLast ? _context.VohalBankaHesabis.FirstOrDefault() : _context.VohalBankaHesabis.OrderByDescending(x => x.BankaHesabiId).FirstOrDefault();
            return val != null ? RedirectToAction("Edit", new { id = val.BankaHesabiId }) : RedirectToAction("Create");
        }
        public ActionResult sonrakiOncekiKayit(bool afterOrBefore, int currentId)
        {
            var val = afterOrBefore ? _context.VohalBankaHesabis.Where(x => x.BankaHesabiId > currentId).FirstOrDefault() : _context.VohalBankaHesabis.OrderByDescending(x => x.BankaHesabiId).Where(x => x.BankaHesabiId < currentId).FirstOrDefault();
            if (val == null)
                return RedirectToAction("ilkSonKayit", new { firstOrlast = !afterOrBefore });
            return RedirectToAction("Edit", new { id = val.BankaHesabiId });
        }
    }
}
