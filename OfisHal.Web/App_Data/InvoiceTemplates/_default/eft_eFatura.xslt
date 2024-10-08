﻿<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="2.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:cac="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2" xmlns:cbc="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2" xmlns:ccts="urn:un:unece:uncefact:documentation:2" xmlns:clm54217="urn:un:unece:uncefact:codelist:specification:54217:2001" xmlns:clm5639="urn:un:unece:uncefact:codelist:specification:5639:1988" xmlns:clm66411="urn:un:unece:uncefact:codelist:specification:66411:2001" xmlns:clmIANAMIMEMediaType="urn:un:unece:uncefact:codelist:specification:IANAMIMEMediaType:2003" xmlns:fn="http://www.w3.org/2005/xpath-functions" xmlns:link="http://www.xbrl.org/2003/linkbase" xmlns:n1="urn:oasis:names:specification:ubl:schema:xsd:Invoice-2" xmlns:qdt="urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2" xmlns:udt="urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2" xmlns:xbrldi="http://xbrl.org/2006/xbrldi" xmlns:xbrli="http://www.xbrl.org/2003/instance" xmlns:xdt="http://www.w3.org/2005/xpath-datatypes" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:xs="http://www.w3.org/2001/XMLSchema" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:lcl="http://www.efatura.gov.tr/local" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" exclude-result-prefixes="cac cbc ccts clm54217 clm5639 clm66411 clmIANAMIMEMediaType fn link n1 qdt udt xbrldi xbrli xdt xlink xs xsd xsi lcl">
  <xsl:variable name="footerNote" select="//n1:Invoice/cbc:Note[not(contains(.,'FOOTER2') or contains(.,'PLAKA'))]" />
  <xsl:character-map name="a">
    <xsl:output-character character="&amp;" string="&amp;" />
    <xsl:output-character character="&quot;" string="&quot;" />
    <xsl:output-character character="&lt;" string="&lt;" />
    <xsl:output-character character="&gt;" string="&gt;" />
    <xsl:output-character character="'" string="'" />
    <xsl:output-character character="" string="" />
    <xsl:output-character character="" string="" />
    <xsl:output-character character="" string="" />
    <xsl:output-character character="" string="" />
    <xsl:output-character character="" string="" />
    <xsl:output-character character="" string="" />
    <xsl:output-character character="" string="" />
    <xsl:output-character character="" string="" />
    <xsl:output-character character="" string="" />
    <xsl:output-character character="" string="" />
    <xsl:output-character character="" string="" />
    <xsl:output-character character="" string="" />
    <xsl:output-character character="" string="" />
    <xsl:output-character character="" string="" />
    <xsl:output-character character="" string="" />
    <xsl:output-character character="" string="" />
    <xsl:output-character character="" string="" />
    <xsl:output-character character="" string="" />
    <xsl:output-character character="" string="" />
    <xsl:output-character character="" string="" />
    <xsl:output-character character="" string="" />
    <xsl:output-character character="" string="" />
    <xsl:output-character character="" string="" />
    <xsl:output-character character="" string="" />
    <xsl:output-character character="" string="" />
    <xsl:output-character character="" string="" />
    <xsl:output-character character="" string="" />
    <xsl:output-character character="" string="" />
    <xsl:output-character character="" string="" />
    <xsl:output-character character="" string="" />
    <xsl:output-character character="" string="" />
    <xsl:output-character character="" string="" />
  </xsl:character-map>
  <xsl:decimal-format name="european" decimal-separator="," grouping-separator="." NaN="" />
  <xsl:output version="4.0" method="html" indent="yes" encoding="UTF-8" doctype-public="-//W3C//DTD HTML 4.01 Transitional//EN" doctype-system="http://www.w3.org/TR/html4/loose.dtd" use-character-maps="a" />
  <xsl:param name="SV_OutputFormat" select="'HTML'" />
  <xsl:variable name="XML" select="/" />
  <xsl:variable name="iskontoCount" select="count(n1:Invoice/cac:InvoiceLine/cac:AllowanceCharge)" />
  <xsl:variable name="irsaliyeCount" select="count(n1:Invoice/cac:DespatchDocumentReference)" />
  <xsl:variable name="iadeCount" select="count(n1:Invoice/cac:BillingReference)" />
  <xsl:variable name="linePerPage" select="100" />
  <xsl:variable name="index" select="1" />
  <xsl:variable name="earchiveCheckCount" select="count(n1:Invoice/cac:AdditionalDocumentReference[cbc:DocumentTypeCode = 'SendingType'])" />
  <xsl:variable name="MusteriAdresi" select="substring-after(//n1:Invoice/cbc:Note[contains(.,'Müşteri Adresi')],':')" />
  <xsl:variable name="legalMonetary" select="n1:Invoice/cac:LegalMonetaryTotal/cbc:AllowanceTotalAmount" />
  <xsl:variable name="linediscount" select="sum(n1:Invoice/cac:InvoiceLine/cac:AllowanceCharge/cbc:Amount)" />
  <xsl:template match="/">
    <html>
      <head>
        <script type="text/javascript"><![CDATA[var QRCode;!function(){function a(a){this.mode=c.MODE_8BIT_BYTE,this.data=a,this.parsedData=[];for(var b=[],d=0,e=this.data.length;e>d;d++){var f=this.data.charCodeAt(d);f>65536?(b[0]=240|(1835008&f)>>>18,b[1]=128|(258048&f)>>>12,b[2]=128|(4032&f)>>>6,b[3]=128|63&f):f>2048?(b[0]=224|(61440&f)>>>12,b[1]=128|(4032&f)>>>6,b[2]=128|63&f):f>128?(b[0]=192|(1984&f)>>>6,b[1]=128|63&f):b[0]=f,this.parsedData=this.parsedData.concat(b)}this.parsedData.length!=this.data.length&&(this.parsedData.unshift(191),this.parsedData.unshift(187),this.parsedData.unshift(239))}function b(a,b){this.typeNumber=a,this.errorCorrectLevel=b,this.modules=null,this.moduleCount=0,this.dataCache=null,this.dataList=[]}function i(a,b){if(void 0==a.length)throw new Error(a.length+"/"+b);for(var c=0;c<a.length&&0==a[c];)c++;this.num=new Array(a.length-c+b);for(var d=0;d<a.length-c;d++)this.num[d]=a[d+c]}function j(a,b){this.totalCount=a,this.dataCount=b}function k(){this.buffer=[],this.length=0}function m(){return"undefined"!=typeof CanvasRenderingContext2D}function n(){var a=!1,b=navigator.userAgent;return/android/i.test(b)&&(a=!0,aMat=b.toString().match(/android ([0-9]\.[0-9])/i),aMat&&aMat[1]&&(a=parseFloat(aMat[1]))),a}function r(a,b){for(var c=1,e=s(a),f=0,g=l.length;g>=f;f++){var h=0;switch(b){case d.L:h=l[f][0];break;case d.M:h=l[f][1];break;case d.Q:h=l[f][2];break;case d.H:h=l[f][3]}if(h>=e)break;c++}if(c>l.length)throw new Error("Too long data");return c}function s(a){var b=encodeURI(a).toString().replace(/\%[0-9a-fA-F]{2}/g,"a");return b.length+(b.length!=a?3:0)}a.prototype={getLength:function(){return this.parsedData.length},write:function(a){for(var b=0,c=this.parsedData.length;c>b;b++)a.put(this.parsedData[b],8)}},b.prototype={addData:function(b){var c=new a(b);this.dataList.push(c),this.dataCache=null},isDark:function(a,b){if(0>a||this.moduleCount<=a||0>b||this.moduleCount<=b)throw new Error(a+","+b);return this.modules[a][b]},getModuleCount:function(){return this.moduleCount},make:function(){this.makeImpl(!1,this.getBestMaskPattern())},makeImpl:function(a,c){this.moduleCount=4*this.typeNumber+17,this.modules=new Array(this.moduleCount);for(var d=0;d<this.moduleCount;d++){this.modules[d]=new Array(this.moduleCount);for(var e=0;e<this.moduleCount;e++)this.modules[d][e]=null}this.setupPositionProbePattern(0,0),this.setupPositionProbePattern(this.moduleCount-7,0),this.setupPositionProbePattern(0,this.moduleCount-7),this.setupPositionAdjustPattern(),this.setupTimingPattern(),this.setupTypeInfo(a,c),this.typeNumber>=7&&this.setupTypeNumber(a),null==this.dataCache&&(this.dataCache=b.createData(this.typeNumber,this.errorCorrectLevel,this.dataList)),this.mapData(this.dataCache,c)},setupPositionProbePattern:function(a,b){for(var c=-1;7>=c;c++)if(!(-1>=a+c||this.moduleCount<=a+c))for(var d=-1;7>=d;d++)-1>=b+d||this.moduleCount<=b+d||(this.modules[a+c][b+d]=c>=0&&6>=c&&(0==d||6==d)||d>=0&&6>=d&&(0==c||6==c)||c>=2&&4>=c&&d>=2&&4>=d?!0:!1)},getBestMaskPattern:function(){for(var a=0,b=0,c=0;8>c;c++){this.makeImpl(!0,c);var d=f.getLostPoint(this);(0==c||a>d)&&(a=d,b=c)}return b},createMovieClip:function(a,b,c){var d=a.createEmptyMovieClip(b,c),e=1;this.make();for(var f=0;f<this.modules.length;f++)for(var g=f*e,h=0;h<this.modules[f].length;h++){var i=h*e,j=this.modules[f][h];j&&(d.beginFill(0,100),d.moveTo(i,g),d.lineTo(i+e,g),d.lineTo(i+e,g+e),d.lineTo(i,g+e),d.endFill())}return d},setupTimingPattern:function(){for(var a=8;a<this.moduleCount-8;a++)null==this.modules[a][6]&&(this.modules[a][6]=0==a%2);for(var b=8;b<this.moduleCount-8;b++)null==this.modules[6][b]&&(this.modules[6][b]=0==b%2)},setupPositionAdjustPattern:function(){for(var a=f.getPatternPosition(this.typeNumber),b=0;b<a.length;b++)for(var c=0;c<a.length;c++){var d=a[b],e=a[c];if(null==this.modules[d][e])for(var g=-2;2>=g;g++)for(var h=-2;2>=h;h++)this.modules[d+g][e+h]=-2==g||2==g||-2==h||2==h||0==g&&0==h?!0:!1}},setupTypeNumber:function(a){for(var b=f.getBCHTypeNumber(this.typeNumber),c=0;18>c;c++){var d=!a&&1==(1&b>>c);this.modules[Math.floor(c/3)][c%3+this.moduleCount-8-3]=d}for(var c=0;18>c;c++){var d=!a&&1==(1&b>>c);this.modules[c%3+this.moduleCount-8-3][Math.floor(c/3)]=d}},setupTypeInfo:function(a,b){for(var c=this.errorCorrectLevel<<3|b,d=f.getBCHTypeInfo(c),e=0;15>e;e++){var g=!a&&1==(1&d>>e);6>e?this.modules[e][8]=g:8>e?this.modules[e+1][8]=g:this.modules[this.moduleCount-15+e][8]=g}for(var e=0;15>e;e++){var g=!a&&1==(1&d>>e);8>e?this.modules[8][this.moduleCount-e-1]=g:9>e?this.modules[8][15-e-1+1]=g:this.modules[8][15-e-1]=g}this.modules[this.moduleCount-8][8]=!a},mapData:function(a,b){for(var c=-1,d=this.moduleCount-1,e=7,g=0,h=this.moduleCount-1;h>0;h-=2)for(6==h&&h--;;){for(var i=0;2>i;i++)if(null==this.modules[d][h-i]){var j=!1;g<a.length&&(j=1==(1&a[g]>>>e));var k=f.getMask(b,d,h-i);k&&(j=!j),this.modules[d][h-i]=j,e--,-1==e&&(g++,e=7)}if(d+=c,0>d||this.moduleCount<=d){d-=c,c=-c;break}}}},b.PAD0=236,b.PAD1=17,b.createData=function(a,c,d){for(var e=j.getRSBlocks(a,c),g=new k,h=0;h<d.length;h++){var i=d[h];g.put(i.mode,4),g.put(i.getLength(),f.getLengthInBits(i.mode,a)),i.write(g)}for(var l=0,h=0;h<e.length;h++)l+=e[h].dataCount;if(g.getLengthInBits()>8*l)throw new Error("code length overflow. ("+g.getLengthInBits()+">"+8*l+")");for(g.getLengthInBits()+4<=8*l&&g.put(0,4);0!=g.getLengthInBits()%8;)g.putBit(!1);for(;;){if(g.getLengthInBits()>=8*l)break;if(g.put(b.PAD0,8),g.getLengthInBits()>=8*l)break;g.put(b.PAD1,8)}return b.createBytes(g,e)},b.createBytes=function(a,b){for(var c=0,d=0,e=0,g=new Array(b.length),h=new Array(b.length),j=0;j<b.length;j++){var k=b[j].dataCount,l=b[j].totalCount-k;d=Math.max(d,k),e=Math.max(e,l),g[j]=new Array(k);for(var m=0;m<g[j].length;m++)g[j][m]=255&a.buffer[m+c];c+=k;var n=f.getErrorCorrectPolynomial(l),o=new i(g[j],n.getLength()-1),p=o.mod(n);h[j]=new Array(n.getLength()-1);for(var m=0;m<h[j].length;m++){var q=m+p.getLength()-h[j].length;h[j][m]=q>=0?p.get(q):0}}for(var r=0,m=0;m<b.length;m++)r+=b[m].totalCount;for(var s=new Array(r),t=0,m=0;d>m;m++)for(var j=0;j<b.length;j++)m<g[j].length&&(s[t++]=g[j][m]);for(var m=0;e>m;m++)for(var j=0;j<b.length;j++)m<h[j].length&&(s[t++]=h[j][m]);return s};for(var c={MODE_NUMBER:1,MODE_ALPHA_NUM:2,MODE_8BIT_BYTE:4,MODE_KANJI:8},d={L:1,M:0,Q:3,H:2},e={PATTERN000:0,PATTERN001:1,PATTERN010:2,PATTERN011:3,PATTERN100:4,PATTERN101:5,PATTERN110:6,PATTERN111:7},f={PATTERN_POSITION_TABLE:[[],[6,18],[6,22],[6,26],[6,30],[6,34],[6,22,38],[6,24,42],[6,26,46],[6,28,50],[6,30,54],[6,32,58],[6,34,62],[6,26,46,66],[6,26,48,70],[6,26,50,74],[6,30,54,78],[6,30,56,82],[6,30,58,86],[6,34,62,90],[6,28,50,72,94],[6,26,50,74,98],[6,30,54,78,102],[6,28,54,80,106],[6,32,58,84,110],[6,30,58,86,114],[6,34,62,90,118],[6,26,50,74,98,122],[6,30,54,78,102,126],[6,26,52,78,104,130],[6,30,56,82,108,134],[6,34,60,86,112,138],[6,30,58,86,114,142],[6,34,62,90,118,146],[6,30,54,78,102,126,150],[6,24,50,76,102,128,154],[6,28,54,80,106,132,158],[6,32,58,84,110,136,162],[6,26,54,82,110,138,166],[6,30,58,86,114,142,170]],G15:1335,G18:7973,G15_MASK:21522,getBCHTypeInfo:function(a){for(var b=a<<10;f.getBCHDigit(b)-f.getBCHDigit(f.G15)>=0;)b^=f.G15<<f.getBCHDigit(b)-f.getBCHDigit(f.G15);return(a<<10|b)^f.G15_MASK},getBCHTypeNumber:function(a){for(var b=a<<12;f.getBCHDigit(b)-f.getBCHDigit(f.G18)>=0;)b^=f.G18<<f.getBCHDigit(b)-f.getBCHDigit(f.G18);return a<<12|b},getBCHDigit:function(a){for(var b=0;0!=a;)b++,a>>>=1;return b},getPatternPosition:function(a){return f.PATTERN_POSITION_TABLE[a-1]},getMask:function(a,b,c){switch(a){case e.PATTERN000:return 0==(b+c)%2;case e.PATTERN001:return 0==b%2;case e.PATTERN010:return 0==c%3;case e.PATTERN011:return 0==(b+c)%3;case e.PATTERN100:return 0==(Math.floor(b/2)+Math.floor(c/3))%2;case e.PATTERN101:return 0==b*c%2+b*c%3;case e.PATTERN110:return 0==(b*c%2+b*c%3)%2;case e.PATTERN111:return 0==(b*c%3+(b+c)%2)%2;default:throw new Error("bad maskPattern:"+a)}},getErrorCorrectPolynomial:function(a){for(var b=new i([1],0),c=0;a>c;c++)b=b.multiply(new i([1,g.gexp(c)],0));return b},getLengthInBits:function(a,b){if(b>=1&&10>b)switch(a){case c.MODE_NUMBER:return 10;case c.MODE_ALPHA_NUM:return 9;case c.MODE_8BIT_BYTE:return 8;case c.MODE_KANJI:return 8;default:throw new Error("mode:"+a)}else if(27>b)switch(a){case c.MODE_NUMBER:return 12;case c.MODE_ALPHA_NUM:return 11;case c.MODE_8BIT_BYTE:return 16;case c.MODE_KANJI:return 10;default:throw new Error("mode:"+a)}else{if(!(41>b))throw new Error("type:"+b);switch(a){case c.MODE_NUMBER:return 14;case c.MODE_ALPHA_NUM:return 13;case c.MODE_8BIT_BYTE:return 16;case c.MODE_KANJI:return 12;default:throw new Error("mode:"+a)}}},getLostPoint:function(a){for(var b=a.getModuleCount(),c=0,d=0;b>d;d++)for(var e=0;b>e;e++){for(var f=0,g=a.isDark(d,e),h=-1;1>=h;h++)if(!(0>d+h||d+h>=b))for(var i=-1;1>=i;i++)0>e+i||e+i>=b||(0!=h||0!=i)&&g==a.isDark(d+h,e+i)&&f++;f>5&&(c+=3+f-5)}for(var d=0;b-1>d;d++)for(var e=0;b-1>e;e++){var j=0;a.isDark(d,e)&&j++,a.isDark(d+1,e)&&j++,a.isDark(d,e+1)&&j++,a.isDark(d+1,e+1)&&j++,(0==j||4==j)&&(c+=3)}for(var d=0;b>d;d++)for(var e=0;b-6>e;e++)a.isDark(d,e)&&!a.isDark(d,e+1)&&a.isDark(d,e+2)&&a.isDark(d,e+3)&&a.isDark(d,e+4)&&!a.isDark(d,e+5)&&a.isDark(d,e+6)&&(c+=40);for(var e=0;b>e;e++)for(var d=0;b-6>d;d++)a.isDark(d,e)&&!a.isDark(d+1,e)&&a.isDark(d+2,e)&&a.isDark(d+3,e)&&a.isDark(d+4,e)&&!a.isDark(d+5,e)&&a.isDark(d+6,e)&&(c+=40);for(var k=0,e=0;b>e;e++)for(var d=0;b>d;d++)a.isDark(d,e)&&k++;var l=Math.abs(100*k/b/b-50)/5;return c+=10*l}},g={glog:function(a){if(1>a)throw new Error("glog("+a+")");return g.LOG_TABLE[a]},gexp:function(a){for(;0>a;)a+=255;for(;a>=256;)a-=255;return g.EXP_TABLE[a]},EXP_TABLE:new Array(256),LOG_TABLE:new Array(256)},h=0;8>h;h++)g.EXP_TABLE[h]=1<<h;for(var h=8;256>h;h++)g.EXP_TABLE[h]=g.EXP_TABLE[h-4]^g.EXP_TABLE[h-5]^g.EXP_TABLE[h-6]^g.EXP_TABLE[h-8];for(var h=0;255>h;h++)g.LOG_TABLE[g.EXP_TABLE[h]]=h;i.prototype={get:function(a){return this.num[a]},getLength:function(){return this.num.length},multiply:function(a){for(var b=new Array(this.getLength()+a.getLength()-1),c=0;c<this.getLength();c++)for(var d=0;d<a.getLength();d++)b[c+d]^=g.gexp(g.glog(this.get(c))+g.glog(a.get(d)));return new i(b,0)},mod:function(a){if(this.getLength()-a.getLength()<0)return this;for(var b=g.glog(this.get(0))-g.glog(a.get(0)),c=new Array(this.getLength()),d=0;d<this.getLength();d++)c[d]=this.get(d);for(var d=0;d<a.getLength();d++)c[d]^=g.gexp(g.glog(a.get(d))+b);return new i(c,0).mod(a)}},j.RS_BLOCK_TABLE=[[1,26,19],[1,26,16],[1,26,13],[1,26,9],[1,44,34],[1,44,28],[1,44,22],[1,44,16],[1,70,55],[1,70,44],[2,35,17],[2,35,13],[1,100,80],[2,50,32],[2,50,24],[4,25,9],[1,134,108],[2,67,43],[2,33,15,2,34,16],[2,33,11,2,34,12],[2,86,68],[4,43,27],[4,43,19],[4,43,15],[2,98,78],[4,49,31],[2,32,14,4,33,15],[4,39,13,1,40,14],[2,121,97],[2,60,38,2,61,39],[4,40,18,2,41,19],[4,40,14,2,41,15],[2,146,116],[3,58,36,2,59,37],[4,36,16,4,37,17],[4,36,12,4,37,13],[2,86,68,2,87,69],[4,69,43,1,70,44],[6,43,19,2,44,20],[6,43,15,2,44,16],[4,101,81],[1,80,50,4,81,51],[4,50,22,4,51,23],[3,36,12,8,37,13],[2,116,92,2,117,93],[6,58,36,2,59,37],[4,46,20,6,47,21],[7,42,14,4,43,15],[4,133,107],[8,59,37,1,60,38],[8,44,20,4,45,21],[12,33,11,4,34,12],[3,145,115,1,146,116],[4,64,40,5,65,41],[11,36,16,5,37,17],[11,36,12,5,37,13],[5,109,87,1,110,88],[5,65,41,5,66,42],[5,54,24,7,55,25],[11,36,12],[5,122,98,1,123,99],[7,73,45,3,74,46],[15,43,19,2,44,20],[3,45,15,13,46,16],[1,135,107,5,136,108],[10,74,46,1,75,47],[1,50,22,15,51,23],[2,42,14,17,43,15],[5,150,120,1,151,121],[9,69,43,4,70,44],[17,50,22,1,51,23],[2,42,14,19,43,15],[3,141,113,4,142,114],[3,70,44,11,71,45],[17,47,21,4,48,22],[9,39,13,16,40,14],[3,135,107,5,136,108],[3,67,41,13,68,42],[15,54,24,5,55,25],[15,43,15,10,44,16],[4,144,116,4,145,117],[17,68,42],[17,50,22,6,51,23],[19,46,16,6,47,17],[2,139,111,7,140,112],[17,74,46],[7,54,24,16,55,25],[34,37,13],[4,151,121,5,152,122],[4,75,47,14,76,48],[11,54,24,14,55,25],[16,45,15,14,46,16],[6,147,117,4,148,118],[6,73,45,14,74,46],[11,54,24,16,55,25],[30,46,16,2,47,17],[8,132,106,4,133,107],[8,75,47,13,76,48],[7,54,24,22,55,25],[22,45,15,13,46,16],[10,142,114,2,143,115],[19,74,46,4,75,47],[28,50,22,6,51,23],[33,46,16,4,47,17],[8,152,122,4,153,123],[22,73,45,3,74,46],[8,53,23,26,54,24],[12,45,15,28,46,16],[3,147,117,10,148,118],[3,73,45,23,74,46],[4,54,24,31,55,25],[11,45,15,31,46,16],[7,146,116,7,147,117],[21,73,45,7,74,46],[1,53,23,37,54,24],[19,45,15,26,46,16],[5,145,115,10,146,116],[19,75,47,10,76,48],[15,54,24,25,55,25],[23,45,15,25,46,16],[13,145,115,3,146,116],[2,74,46,29,75,47],[42,54,24,1,55,25],[23,45,15,28,46,16],[17,145,115],[10,74,46,23,75,47],[10,54,24,35,55,25],[19,45,15,35,46,16],[17,145,115,1,146,116],[14,74,46,21,75,47],[29,54,24,19,55,25],[11,45,15,46,46,16],[13,145,115,6,146,116],[14,74,46,23,75,47],[44,54,24,7,55,25],[59,46,16,1,47,17],[12,151,121,7,152,122],[12,75,47,26,76,48],[39,54,24,14,55,25],[22,45,15,41,46,16],[6,151,121,14,152,122],[6,75,47,34,76,48],[46,54,24,10,55,25],[2,45,15,64,46,16],[17,152,122,4,153,123],[29,74,46,14,75,47],[49,54,24,10,55,25],[24,45,15,46,46,16],[4,152,122,18,153,123],[13,74,46,32,75,47],[48,54,24,14,55,25],[42,45,15,32,46,16],[20,147,117,4,148,118],[40,75,47,7,76,48],[43,54,24,22,55,25],[10,45,15,67,46,16],[19,148,118,6,149,119],[18,75,47,31,76,48],[34,54,24,34,55,25],[20,45,15,61,46,16]],j.getRSBlocks=function(a,b){var c=j.getRsBlockTable(a,b);if(void 0==c)throw new Error("bad rs block @ typeNumber:"+a+"/errorCorrectLevel:"+b);for(var d=c.length/3,e=[],f=0;d>f;f++)for(var g=c[3*f+0],h=c[3*f+1],i=c[3*f+2],k=0;g>k;k++)e.push(new j(h,i));return e},j.getRsBlockTable=function(a,b){switch(b){case d.L:return j.RS_BLOCK_TABLE[4*(a-1)+0];case d.M:return j.RS_BLOCK_TABLE[4*(a-1)+1];case d.Q:return j.RS_BLOCK_TABLE[4*(a-1)+2];case d.H:return j.RS_BLOCK_TABLE[4*(a-1)+3];default:return void 0}},k.prototype={get:function(a){var b=Math.floor(a/8);return 1==(1&this.buffer[b]>>>7-a%8)},put:function(a,b){for(var c=0;b>c;c++)this.putBit(1==(1&a>>>b-c-1))},getLengthInBits:function(){return this.length},putBit:function(a){var b=Math.floor(this.length/8);this.buffer.length<=b&&this.buffer.push(0),a&&(this.buffer[b]|=128>>>this.length%8),this.length++}};var l=[[17,14,11,7],[32,26,20,14],[53,42,32,24],[78,62,46,34],[106,84,60,44],[134,106,74,58],[154,122,86,64],[192,152,108,84],[230,180,130,98],[271,213,151,119],[321,251,177,137],[367,287,203,155],[425,331,241,177],[458,362,258,194],[520,412,292,220],[586,450,322,250],[644,504,364,280],[718,560,394,310],[792,624,442,338],[858,666,482,382],[929,711,509,403],[1003,779,565,439],[1091,857,611,461],[1171,911,661,511],[1273,997,715,535],[1367,1059,751,593],[1465,1125,805,625],[1528,1190,868,658],[1628,1264,908,698],[1732,1370,982,742],[1840,1452,1030,790],[1952,1538,1112,842],[2068,1628,1168,898],[2188,1722,1228,958],[2303,1809,1283,983],[2431,1911,1351,1051],[2563,1989,1423,1093],[2699,2099,1499,1139],[2809,2213,1579,1219],[2953,2331,1663,1273]],o=function(){var a=function(a,b){this._el=a,this._htOption=b};return a.prototype.draw=function(a){function g(a,b){var c=document.createElementNS("http://www.w3.org/2000/svg",a);for(var d in b)b.hasOwnProperty(d)&&c.setAttribute(d,b[d]);return c}var b=this._htOption,c=this._el,d=a.getModuleCount();Math.floor(b.width/d),Math.floor(b.height/d),this.clear();var h=g("svg",{viewBox:"0 0 "+String(d)+" "+String(d),width:"100%",height:"100%",fill:b.colorLight});h.setAttributeNS("http://www.w3.org/2000/xmlns/","xmlns:xlink","http://www.w3.org/1999/xlink"),c.appendChild(h),h.appendChild(g("rect",{fill:b.colorDark,width:"1",height:"1",id:"template"}));for(var i=0;d>i;i++)for(var j=0;d>j;j++)if(a.isDark(i,j)){var k=g("use",{x:String(i),y:String(j)});k.setAttributeNS("http://www.w3.org/1999/xlink","href","#template"),h.appendChild(k)}},a.prototype.clear=function(){for(;this._el.hasChildNodes();)this._el.removeChild(this._el.lastChild)},a}(),p="svg"===document.documentElement.tagName.toLowerCase(),q=p?o:m()?function(){function a(){this._elImage.src=this._elCanvas.toDataURL("image/png"),this._elImage.style.display="block",this._elCanvas.style.display="none"}function d(a,b){var c=this;if(c._fFail=b,c._fSuccess=a,null===c._bSupportDataURI){var d=document.createElement("img"),e=function(){c._bSupportDataURI=!1,c._fFail&&_fFail.call(c)},f=function(){c._bSupportDataURI=!0,c._fSuccess&&c._fSuccess.call(c)};return d.onabort=e,d.onerror=e,d.onload=f,d.src="data:image/gif;base64,iVBORw0KGgoAAAANSUhEUgAAAAUAAAAFCAYAAACNbyblAAAAHElEQVQI12P4//8/w38GIAXDIBKE0DHxgljNBAAO9TXL0Y4OHwAAAABJRU5ErkJggg==",void 0}c._bSupportDataURI===!0&&c._fSuccess?c._fSuccess.call(c):c._bSupportDataURI===!1&&c._fFail&&c._fFail.call(c)}if(this._android&&this._android<=2.1){var b=1/window.devicePixelRatio,c=CanvasRenderingContext2D.prototype.drawImage;CanvasRenderingContext2D.prototype.drawImage=function(a,d,e,f,g,h,i,j){if("nodeName"in a&&/img/i.test(a.nodeName))for(var l=arguments.length-1;l>=1;l--)arguments[l]=arguments[l]*b;else"undefined"==typeof j&&(arguments[1]*=b,arguments[2]*=b,arguments[3]*=b,arguments[4]*=b);c.apply(this,arguments)}}var e=function(a,b){this._bIsPainted=!1,this._android=n(),this._htOption=b,this._elCanvas=document.createElement("canvas"),this._elCanvas.width=b.width,this._elCanvas.height=b.height,a.appendChild(this._elCanvas),this._el=a,this._oContext=this._elCanvas.getContext("2d"),this._bIsPainted=!1,this._elImage=document.createElement("img"),this._elImage.style.display="none",this._el.appendChild(this._elImage),this._bSupportDataURI=null};return e.prototype.draw=function(a){var b=this._elImage,c=this._oContext,d=this._htOption,e=a.getModuleCount(),f=d.width/e,g=d.height/e,h=Math.round(f),i=Math.round(g);b.style.display="none",this.clear();for(var j=0;e>j;j++)for(var k=0;e>k;k++){var l=a.isDark(j,k),m=k*f,n=j*g;c.strokeStyle=l?d.colorDark:d.colorLight,c.lineWidth=1,c.fillStyle=l?d.colorDark:d.colorLight,c.fillRect(m,n,f,g),c.strokeRect(Math.floor(m)+.5,Math.floor(n)+.5,h,i),c.strokeRect(Math.ceil(m)-.5,Math.ceil(n)-.5,h,i)}this._bIsPainted=!0},e.prototype.makeImage=function(){this._bIsPainted&&d.call(this,a)},e.prototype.isPainted=function(){return this._bIsPainted},e.prototype.clear=function(){this._oContext.clearRect(0,0,this._elCanvas.width,this._elCanvas.height),this._bIsPainted=!1},e.prototype.round=function(a){return a?Math.floor(1e3*a)/1e3:a},e}():function(){var a=function(a,b){this._el=a,this._htOption=b};return a.prototype.draw=function(a){for(var b=this._htOption,c=this._el,d=a.getModuleCount(),e=Math.floor(b.width/d),f=Math.floor(b.height/d),g=['<table style="border:0;border-collapse:collapse;">'],h=0;d>h;h++){g.push("<tr>");for(var i=0;d>i;i++)g.push('<td style="border:0;border-collapse:collapse;padding:0;margin:0;width:'+e+"px;height:"+f+"px;background-color:"+(a.isDark(h,i)?b.colorDark:b.colorLight)+';"></td>');g.push("</tr>")}g.push("</table>"),c.innerHTML=g.join("");var j=c.childNodes[0],k=(b.width-j.offsetWidth)/2,l=(b.height-j.offsetHeight)/2;k>0&&l>0&&(j.style.margin=l+"px "+k+"px")},a.prototype.clear=function(){this._el.innerHTML=""},a}();QRCode=function(a,b){if(this._htOption={width:256,height:256,typeNumber:4,colorDark:"#000000",colorLight:"#ffffff",correctLevel:d.H},"string"==typeof b&&(b={text:b}),b)for(var c in b)this._htOption[c]=b[c];"string"==typeof a&&(a=document.getElementById(a)),this._android=n(),this._el=a,this._oQRCode=null,this._oDrawing=new q(this._el,this._htOption),this._htOption.text&&this.makeCode(this._htOption.text)},QRCode.prototype.makeCode=function(a){this._oQRCode=new b(r(a,this._htOption.correctLevel),this._htOption.correctLevel),this._oQRCode.addData(a),this._oQRCode.make(),this._el.title=a,this._oDrawing.draw(this._oQRCode),this.makeImage()},QRCode.prototype.makeImage=function(){"function"==typeof this._oDrawing.makeImage&&(!this._android||this._android>=3)&&this._oDrawing.makeImage()},QRCode.prototype.clear=function(){this._oDrawing.clear()},QRCode.CorrectLevel=d}();]]></script>
        <title />
        <style type="text/css">
          body {
          background-color: #FFFFFF;
          font-family:'Tahoma', "Times New Roman", Times, serif;
          font-size: 11px;
          color: black;
		  }
          h1, h2 {
          padding-bottom: 3px;
          padding-top: 3px;
          margin-bottom: 5px;
          text-transform: uppercase;
          font-family: Arial, Helvetica, sans-serif;
          }
          h1 {
          font-size: 1.4em;
          text-transform:none;
          }
          h2 {
          font-size: 1em;
          color: brown;
          }
          h3 {
          font-size: 1em;
          color: #333333;
          text-align: justify;
          margin: 0;
          padding: 0;
          }
          h4 {
          font-size: 1.1em;
          font-style: bold;
          font-family: Arial, Helvetica, sans-serif;
          color: #000000;
          margin: 0;
          padding: 0;
          }
          hr {
          height:2px;
          color: #000000;
          background-color: #000000;
          border-bottom: 1px solid #000000;
          }
          p, ul, ol {
          margin-top: 1.5em;
          }
          ul, ol {
          margin-left: 3em;
          }
          blockquote {
          margin-left: 3em;
          margin-right: 3em;
          font-style: italic;
          }
          a {
          text-decoration: none;
          color: #70A300;
          }
          a:hover {
          border: none;
          color: #70A300;
          }
          #despatchTable {
          border-collapse:collapse;
          font-size:11px;
          float:right;
          border-color:gray;
          }
          #customerPartyTable {
          border-width: 0px;
          border-spacing:;
          border-style: inset;
          border-color: gray;
          border-collapse: collapse;
          background-color:
          }
          #customerIDTable {
          border-width: 2px;
          border-spacing:;
          border-style: inset;
          border-color: gray;
          border-collapse: collapse;
          background-color:
          }
          #customerIDTableTd {
          border-width: 2px;
          border-spacing:;
          border-style: inset;
          border-color: gray;
          border-collapse: collapse;
          background-color:
          }
          #lineTable {
          border-width:2px;
          border-spacing:;
          border-style: inset;
          border-color: black;
          border-collapse: collapse;
          background-color:;
          }

          #lineTable th{
          border-width: 1px;
          padding: 1px;
          border-style: inset;
          border-color: black;
          background-color: white;
          }
          #lineTable td{
          border-width: 1px;
          padding: 1px;
          border-style: inset;
          border-color: black;
          background-color: white;
          }
          #lineTable tr{
          border-width: 1px;
          padding: 0px;
          border-style: inset;
          border-color: black;
          background-color: white;
          -moz-border-radius:;
          }
		  
          #lineTableHeader th{
          background-color:#43afa7;
          color:white;
          text-align:center;
          }
		  
          #lineTableDummyTd {
          border-width: 1px;
          border-color:white;
          padding: 1px;
          border-style: inset;
          border-color: black;
          background-color: white;
          }
		  #totalTable {
          font-size:10px;
		  font-weight:bold;		  
		  font-family:'Tahoma';
		  border:0;
          }
		  
          #notesTable {
          font-family : "Courier New";
          font-size: 13px;
          line-height: 20px;
          border-width: 2px;
          border-style: inset;
          border-color: black;
          width: 900px;
		  font-weight: bold;
          }
          #notesTableTd {
          font-family : "Courier New";
          font-size: 13px;
          line-height: 2px;
          border-width: 0px;
          border-spacing:;
          border-style: inset;
          border-color: black;
          border-collapse: collapse;
          background-color:
          }
		  #qrCodeDiv {
          border-width: 2px;
          border-style: inset;
          border-color: black;
          width: 900px;
		  text-align: left;
          }
          table {
          border-spacing:0px;
          }
          td {
          border-color:gray;
          }
		  .allowanceChargeTable{margin-top:5px;font-size: 13px;border: 2px solid black;text-align: left;border-collapse: collapse;color:#414141;}
		  .allowanceChargeTable tr{padding: 0px;border: none;background-color: #fff;}
		  .allowanceChargeTable th{background-color: #43afa7;color:white;text-align:center;border-bottom: 1px solid #DCDCDB;font-weight: bold;height: 19px;padding-left: 4px;padding-right: 4px;}
		  .allowanceChargeTable td{border: 1px solid #DCDCDB;font-size: 11px;text-align:right;height: 17px;}
		  
		  #budgetContainerTable{margin-top:5px;float:right;font-size: 13px;border: 2px solid black;text-align: left;border-collapse: collapse;color:#414141;}
          #budgetContainerTable tr{padding: 0px;border: none;background-color: #fff;}
          #budgetContainerTable td{border: 1px solid #DCDCDB;font-size: 11px;width:100px;text-align:right;height: 17px;}
          #budgetContainerTable th{background-color: #43afa7;color:white;text-align:left;border-bottom: 1px solid #DCDCDB;font-weight: bold;height: 19px;padding-left: 4px;padding-right: 4px;}
		  
		  .invoiceDetails{float:left; width:300px;}
		  .invoiceDetails .invoiceID{color:#6699FF;font-weight:bold;font-size: 15px;}
		  .invoiceDetails td{color:#000000;font-weight:bold;white-space:nowrap; }
		  #invoiceDetailTbl {border-left: 15px solid #6699FF;}
		  .invoiceCustomer{float:left; vertical-align:top;}
		  .lbl{font-weight:bold;color:#000000;text-transform:none !important;}
		  
		  #ettn{
          border: 1px solid #6699FF;
          border-collapse: collapse;
          border-left-width:5px;
          font-size: 11px;}
          #ettn p{width:293px; height:13px;}
		  .containerTr{float:left;border-spacing: 0px;}
		  .invoiceInfo{width:900px;}
		  #invoiceTotal{width: 900px;}
		  
		  #hesapBilgileri table{border:1px solid gray;}
		  #hesapBilgileri table tr{border:1px solid gray;}
		  #hesapBilgileri table th{border: 1px solid gray;
									text-align:center; 
									font-size:16px; 
									line-height:25px; 
									background-color:#43afa7;
									color: white;}
		  #hesapBilgileri table td{border: 1px solid gray; 
									font-size: 12px; 
									font-weight: bold; 
									padding-left: 3px;
									width:25%;}
		  </style>
		  <xsl:if test="(//n1:Invoice/cbc:ProfileID='HKS'">
			  <style>
				  #lineTableHeader th{background-color:#6699ff;}
				  .allowanceChargeTable th{background-color: #6699ff;}
				  #budgetContainerTable th{background-color: #6699ff;}
				  #hesapBilgileri table th{background-color:#6699ff;}
			  </style>
		  </xsl:if>
        <title>E-Arşiv Fatura</title>
      </head>
      <body style="margin-left=0.6in; margin-right=0.6in; margin-top=0.79in; margin-bottom=0.79in">
        <table border="0" cellspacing="0px" width="900" cellpadding="0px">
          <tr class="containerTr">
            <td>
              <table>
                <tr>
                  <td id="companyLogo" width="300" align="left" valign="middle">
                    <img style="width: 200px;" align="center" alt="Company Logo" src="" />
                  </td>
                  <td class="invoiceLogo" width="300" align="center" valign="middle">
                    <xsl:choose>
                      <xsl:when test="//n1:Invoice/cbc:ProfileID='EARSIVFATURA'">
                        <img align="center" alt="E_Arşiv Logo" src="data:image/jpeg;base64,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" />
                        <h1 align="center">
                          <span style="font-weight:bold; ">
                            <xsl:text>E-Arşiv Fatura</xsl:text>
                          </span>
                        </h1>
                      </xsl:when>
                      <xsl:otherwise>
                        <img align="center" alt="E-Fatura Logo" src="data:image/jpeg;base64,/9j/4QAYRXhpZgAASUkqAAgAAAAAAAAAAAAAAP/sABFEdWNreQABAAQAAABkAAD/4QMZaHR0cDovL25zLmFkb2JlLmNvbS94YXAvMS4wLwA8P3hwYWNrZXQgYmVnaW49Iu+7vyIgaWQ9Ilc1TTBNcENlaGlIenJlU3pOVGN6a2M5ZCI/PiA8eDp4bXBtZXRhIHhtbG5zOng9ImFkb2JlOm5zOm1ldGEvIiB4OnhtcHRrPSJBZG9iZSBYTVAgQ29yZSA1LjYtYzEzMiA3OS4xNTkyODQsIDIwMTYvMDQvMTktMTM6MTM6NDAgICAgICAgICI+IDxyZGY6UkRGIHhtbG5zOnJkZj0iaHR0cDovL3d3dy53My5vcmcvMTk5OS8wMi8yMi1yZGYtc3ludGF4LW5zIyI+IDxyZGY6RGVzY3JpcHRpb24gcmRmOmFib3V0PSIiIHhtbG5zOnhtcE1NPSJodHRwOi8vbnMuYWRvYmUuY29tL3hhcC8xLjAvbW0vIiB4bWxuczpzdFJlZj0iaHR0cDovL25zLmFkb2JlLmNvbS94YXAvMS4wL3NUeXBlL1Jlc291cmNlUmVmIyIgeG1sbnM6eG1wPSJodHRwOi8vbnMuYWRvYmUuY29tL3hhcC8xLjAvIiB4bXBNTTpEb2N1bWVudElEPSJ4bXAuZGlkOjZDNDJBNEI2QjVCRDExRThCQjM0REIwQkZGMEQxODY0IiB4bXBNTTpJbnN0YW5jZUlEPSJ4bXAuaWlkOjZDNDJBNEI1QjVCRDExRThCQjM0REIwQkZGMEQxODY0IiB4bXA6Q3JlYXRvclRvb2w9IkFkb2JlIFBob3Rvc2hvcCBDUzQgV2luZG93cyI+IDx4bXBNTTpEZXJpdmVkRnJvbSBzdFJlZjppbnN0YW5jZUlEPSIzREVENkU1N0FDREVDNEJBNzkxNUM2M0NCN0RENzM0NyIgc3RSZWY6ZG9jdW1lbnRJRD0iM0RFRDZFNTdBQ0RFQzRCQTc5MTVDNjNDQjdERDczNDciLz4gPC9yZGY6RGVzY3JpcHRpb24+IDwvcmRmOlJERj4gPC94OnhtcG1ldGE+IDw/eHBhY2tldCBlbmQ9InIiPz7/7gAOQWRvYmUAZMAAAAAB/9sAhAABAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEB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" />
                        <h1 align="center">
                          <span style="font-weight:bold;">
                            <xsl:text>e-Fatura</xsl:text>
                          </span>
                        </h1>
                      </xsl:otherwise>
                    </xsl:choose>
                  </td>
                  <td width="300" align="right">
					<div id="qrcode"/>
					<div id="qrvalue" style="visibility: hidden; height: 20px; width: 20px; display:none">
						{"vkntckn":"<xsl:value-of select="n1:Invoice/cac:AccountingSupplierParty/cac:Party/cac:PartyIdentification/cbc:ID[@schemeID = 'TCKN' or @schemeID = 'VKN']"/>", "avkntckn":"<xsl:value-of select="n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:PartyIdentification/cbc:ID[@schemeID = 'TCKN' or @schemeID = 'VKN']"/><xsl:text> </xsl:text>", "senaryo":"<xsl:value-of select="n1:Invoice/cbc:ProfileID"/>", "tip":"<xsl:value-of select="n1:Invoice/cbc:InvoiceTypeCode"/>", "tarih":"<xsl:value-of select="n1:Invoice/cbc:IssueDate"/>", "no":"<xsl:value-of select="n1:Invoice/cbc:ID"/>", "ettn":"<xsl:value-of select="n1:Invoice/cbc:UUID"/>", "parabirimi":"<xsl:value-of select="n1:Invoice/cbc:DocumentCurrencyCode"/>", "malhizmettoplam":"<xsl:value-of select="n1:Invoice/cac:LegalMonetaryTotal/cbc:LineExtensionAmount"/><xsl:for-each select="n1:Invoice/cac:TaxTotal/cac:TaxSubtotal[cac:TaxCategory/cac:TaxScheme/cbc:TaxTypeCode = '0015']">"<xsl:text>, "kdvmatrah</xsl:text>(<xsl:value-of select="cbc:Percent"/>)":"<xsl:value-of select="cbc:TaxableAmount"/>"</xsl:for-each><xsl:for-each select="n1:Invoice/cac:TaxTotal/cac:TaxSubtotal[cac:TaxCategory/cac:TaxScheme/cbc:TaxTypeCode = '0015']"><xsl:text>, "hesaplanankdv</xsl:text>(<xsl:value-of select="cbc:Percent"/>)":"<xsl:value-of select="cbc:TaxAmount"/>",</xsl:for-each>"vergidahil":"<xsl:value-of select="n1:Invoice/cac:LegalMonetaryTotal/cbc:TaxInclusiveAmount"/>", "odenecek":"<xsl:value-of select="n1:Invoice/cac:LegalMonetaryTotal/cbc:PayableAmount"/>"}
					</div>
					<script type="text/javascript">
						var qrcode = new QRCode(document.getElementById("qrcode"), {
							width : 150,
							height : 150,
							correctLevel : QRCode.CorrectLevel.Q
						});

						function makeCode (msg) {
							qrcode.makeCode(msg);
						}

						makeCode(document.getElementById("qrvalue").innerHTML);
					</script>
				  </td>
                </tr>
              </table>
            </td>
          </tr>
		  <tr class="containerTr">
            <td>
              <table>
                <tr>
                  <td class="invoiceCustomer" width="300" valign="top">
                    <table>
                      <tr>
                        <td>
                          <table style="border-color:#000000; " border="0" cellspacing="0px" width="300" cellpadding="0px">
                            <tr>
                              <td width="38%">
                                <br />
                                <table align="center" border="0" width="100%" style="margin-bottom: 5px;border: 1px solid #6699FF; border-left-width:5px; width:100%;padding:5px;">
                                  <tbody>
                                    <tr align="left">
                                      <xsl:for-each select="n1:Invoice">
                                        <xsl:for-each select="cac:AccountingSupplierParty">
                                          <xsl:for-each select="cac:Party">
                                            <td align="left">
                                              <xsl:if test="cac:PartyName">
                                                <span style="font-weight:bold ;">
                                                  <xsl:value-of select="cac:PartyName/cbc:Name" />
                                                </span>
                                                <br />
                                              </xsl:if>
                                              <xsl:for-each select="cac:Person">
                                                <xsl:for-each select="cbc:Title">
                                                  <xsl:apply-templates />
                                                  <span>
                                                    <xsl:text> </xsl:text>
                                                  </span>
                                                </xsl:for-each>
                                                <xsl:for-each select="cbc:FirstName">
                                                  <xsl:apply-templates />
                                                  <span>
                                                    <xsl:text> </xsl:text>
                                                  </span>
                                                </xsl:for-each>
                                                <xsl:for-each select="cbc:MiddleName">
                                                  <xsl:apply-templates />
                                                  <span>
                                                    <xsl:text> </xsl:text>
                                                  </span>
                                                </xsl:for-each>
                                                <xsl:for-each select="cbc:FamilyName">
                                                  <xsl:apply-templates />
                                                  <span>
                                                    <xsl:text> </xsl:text>
                                                  </span>
                                                </xsl:for-each>
                                                <xsl:for-each select="cbc:NameSuffix">
                                                  <xsl:apply-templates />
                                                </xsl:for-each>
                                              </xsl:for-each>
                                            </td>
                                          </xsl:for-each>
                                        </xsl:for-each>
                                      </xsl:for-each>
                                    </tr>
                                    <tr align="left">
                                      <xsl:for-each select="n1:Invoice">
                                        <xsl:for-each select="cac:AccountingSupplierParty">
                                          <xsl:for-each select="cac:Party">
                                            <td align="left">
                                              <xsl:for-each select="cac:PostalAddress">
                                                <xsl:for-each select="cbc:StreetName">
                                                  <xsl:apply-templates />
                                                  <span>
                                                    <xsl:text> </xsl:text>
                                                  </span>
                                                </xsl:for-each>
                                                <xsl:for-each select="cbc:BuildingName">
                                                  <xsl:apply-templates />
                                                </xsl:for-each>
                                                <xsl:if test="cbc:BuildingNumber != ''">
                                                  <span>
                                                    <xsl:text> No:</xsl:text>
                                                  </span>
                                                  <xsl:for-each select="cbc:BuildingNumber">
                                                    <xsl:apply-templates />
                                                  </xsl:for-each>
                                                  <span>
                                                    <xsl:text> </xsl:text>
                                                  </span>
                                                  <br />
                                                </xsl:if>
                                                <xsl:for-each select="cbc:PostalZone">
                                                  <xsl:apply-templates />
                                                  <span>
                                                    <xsl:text> </xsl:text>
                                                  </span>
                                                </xsl:for-each>
                                                <xsl:for-each select="cbc:CitySubdivisionName">
                                                  <xsl:apply-templates />
                                                </xsl:for-each>
                                                <xsl:for-each select="cbc:CityName">
                                                  <xsl:if test=". != ''">
                                                    <span>
                                                      <xsl:text> / </xsl:text>
                                                    </span>
                                                    <xsl:apply-templates />
                                                    <span>
                                                      <xsl:text> </xsl:text>
                                                    </span>
                                                  </xsl:if>
                                                </xsl:for-each>
                                              </xsl:for-each>
                                            </td>
                                          </xsl:for-each>
                                        </xsl:for-each>
                                      </xsl:for-each>
                                    </tr>
                                    <xsl:if test="//n1:Invoice/cac:AccountingSupplierParty/cac:Party/cac:Contact/cbc:Telephone !='' or //n1:Invoice/cac:AccountingSupplierParty/cac:Party/cac:Contact/cbc:Telefax !=''">
                                      <tr align="left">
                                        <xsl:for-each select="n1:Invoice">
                                          <xsl:for-each select="cac:AccountingSupplierParty">
                                            <xsl:for-each select="cac:Party">
                                              <td align="left">
                                                <xsl:for-each select="cac:Contact">
                                                  <xsl:if test="cbc:Telephone != ''">
                                                    <span>
                                                      <xsl:text>Tel: </xsl:text>
                                                    </span>
                                                    <xsl:for-each select="cbc:Telephone">
                                                      <xsl:apply-templates />
                                                    </xsl:for-each>
                                                  </xsl:if>
                                                  <xsl:if test="cbc:Telefax != ''">
                                                    <span>
                                                      <xsl:text> Fax: </xsl:text>
                                                    </span>
                                                    <xsl:for-each select="cbc:Telefax">
                                                      <xsl:apply-templates />
                                                    </xsl:for-each>
                                                  </xsl:if>
                                                  <span>
                                                    <xsl:text> </xsl:text>
                                                  </span>
                                                </xsl:for-each>
                                              </td>
                                            </xsl:for-each>
                                          </xsl:for-each>
                                        </xsl:for-each>
                                      </tr>
                                    </xsl:if>
                                    <xsl:for-each select="//n1:Invoice/cac:AccountingSupplierParty/cac:Party/cbc:WebsiteURI">
                                      <xsl:if test=". !=''">
                                        <tr align="left">
                                          <td>
                                            <xsl:text>Web Sitesi: </xsl:text>
                                            <xsl:value-of select="." />
                                          </td>
                                        </tr>
                                      </xsl:if>
                                    </xsl:for-each>
                                    <xsl:for-each select="//n1:Invoice/cac:AccountingSupplierParty/cac:Party/cac:Contact/cbc:ElectronicMail">
                                      <xsl:if test=". !=''">
                                        <tr align="left">
                                          <td>
                                            <xsl:text>E-Posta: </xsl:text>
                                            <xsl:value-of select="." />
                                          </td>
                                        </tr>
                                      </xsl:if>
                                    </xsl:for-each>
                                    <tr align="left">
                                      <xsl:for-each select="n1:Invoice">
                                        <xsl:for-each select="cac:AccountingSupplierParty">
                                          <xsl:for-each select="cac:Party">
                                            <xsl:if test="cac:PartyTaxScheme/cac:TaxScheme/cbc:Name !=''">
                                              <td align="left">
                                                <span>
                                                  <xsl:text>Vergi Dairesi: </xsl:text>
                                                </span>
                                                <xsl:for-each select="cac:PartyTaxScheme">
                                                  <xsl:for-each select="cac:TaxScheme">
                                                    <xsl:for-each select="cbc:Name">
                                                      <xsl:apply-templates />
                                                    </xsl:for-each>
                                                  </xsl:for-each>
                                                  <span>
                                                    <xsl:text>  </xsl:text>
                                                  </span>
                                                </xsl:for-each>
                                              </td>
                                            </xsl:if>
                                          </xsl:for-each>
                                        </xsl:for-each>
                                      </xsl:for-each>
                                    </tr>
                                    <xsl:for-each select="//n1:Invoice/cac:AccountingSupplierParty/cac:Party/cac:PartyIdentification">
                                      <xsl:if test="cbc:ID !=''">
                                        <tr align="left">
                                          <td>
                                            <xsl:value-of select="cbc:ID/@schemeID" />
                                            <xsl:text>: </xsl:text>
                                            <xsl:value-of select="cbc:ID" />
                                          </td>
                                        </tr>
                                      </xsl:if>
                                    </xsl:for-each>
                                  </tbody>
                                </table>
                              </td>
                            </tr>
                          </table>
                        </td>
                      </tr>
                    </table>
                  </td>
                  <td width="300">
                  </td>
                  <td class="invoiceDetails" width="200">
                    <table align="right">
                      <tr>
                        <td class="invoiceID">
                          <span class="invoiceDetailColor">Fatura No: </span>
                          <xsl:value-of select="n1:Invoice/cbc:ID" />
                        </td>
                      </tr>
                      <tr>
                        <td>
                          <table id="invoiceDetailTbl">
                            <tr>
                              <td class="invoiceDetailColor" style="white-space:nowrap;">Özelleştirme No</td>
                              <td class="doubleDot">:</td>
                              <td>
                                <xsl:value-of select="n1:Invoice/cbc:CustomizationID" />
                              </td>
                            </tr>
                            <tr>
                              <td class="invoiceDetailColor">Senaryo</td>
                              <td class="doubleDot">:</td>
                              <td class="capital">
                                <xsl:value-of select="n1:Invoice/cbc:ProfileID" />
                              </td>
                            </tr>
                            <tr>
                              <td class="invoiceDetailColor" style="white-space:nowrap;">Fatura Tipi</td>
                              <td class="doubleDot">:</td>
                              <td class="capital">
                                <xsl:value-of select="n1:Invoice/cbc:InvoiceTypeCode" />
                              </td>
                            </tr>
                            <xsl:for-each select="$footerNote">
                              <xsl:if test="contains(.,'Stok Giriş Tarihi')">
                                <tr>
                                  <td class="invoiceDetailColor" style="white-space:nowrap;">Stok Giriş Tarihi</td>
                                  <td class="doubleDot">:</td>
                                  <td>
                                    <xsl:value-of select="substring-after(//n1:Invoice/cbc:Note[contains(.,'Stok Giriş Tarihi')],':')" />
                                  </td>
                                </tr>
                              </xsl:if>
                            </xsl:for-each>
                            <xsl:for-each select="$footerNote">
                              <xsl:if test="contains(.,'Marka')">
                                <tr>
                                  <td class="invoiceDetailColor" style="white-space:nowrap;">Marka</td>
                                  <td class="doubleDot">:</td>
                                  <td>
                                    <xsl:value-of select="substring-after(//n1:Invoice/cbc:Note[contains(.,'Marka')],':')" />
                                  </td>
                                </tr>
                              </xsl:if>
                            </xsl:for-each>
                            <tr>
                              <td class="invoiceDetailColor" style="white-space:nowrap;">Düzenleme Tarihi</td>
                              <td class="doubleDot">:</td>
                              <td>
                                <xsl:for-each select="n1:Invoice/cbc:IssueDate">
                                  <xsl:value-of select="substring(.,9,2)" />.<xsl:value-of select="substring(.,6,2)" />.<xsl:value-of select="substring(.,1,4)" /></xsl:for-each>
                              </td>
                            </tr>
                            <tr>
                              <td class="invoiceDetailColor" style="white-space:nowrap;">Düzenleme Zamanı</td>
                              <td class="doubleDot">:</td>
                              <td>
                                <xsl:for-each select="n1:Invoice/cbc:IssueTime">
                                  <xsl:value-of select="." />
                                </xsl:for-each>
                              </td>
                            </tr>
                            <xsl:for-each select="n1:Invoice/cac:DespatchDocumentReference">
                              <tr>
                                <td class="invoiceDetailColor" style="white-space:nowrap;">İrsaliye No</td>
                                <td class="doubleDot">:</td>
                                <td>
                                  <xsl:value-of select="cbc:ID" />
                                </td>
                              </tr>
                              <tr>
                                <td class="invoiceDetailColor" style="white-space:nowrap;">İrsaliye Tarihi</td>
                                <td class="doubleDot">:</td>
                                <td align="left">
                                  <xsl:for-each select="cbc:IssueDate">
                                    <xsl:value-of select="substring(.,9,2)" />.<xsl:value-of select="substring(.,6,2)" />.<xsl:value-of select="substring(.,1,4)" /></xsl:for-each>
                                </td>
                              </tr>
                            </xsl:for-each>
                            <xsl:for-each select="n1:Invoice/cac:OrderReference">
                              <tr>
                                <td class="invoiceDetailColor" style="white-space:nowrap;">Sipariş No</td>
                                <td class="doubleDot">:</td>
                                <td>
                                  <xsl:value-of select="cbc:ID" />
                                </td>
                              </tr>
                              <tr>
                                <td class="invoiceDetailColor" style="white-space:nowrap;">Sipariş Tarihi</td>
                                <td class="doubleDot">:</td>
                                <td align="left">
                                  <xsl:for-each select="cbc:IssueDate">
                                    <xsl:value-of select="substring(.,9,2)" />.<xsl:value-of select="substring(.,6,2)" />.<xsl:value-of select="substring(.,1,4)" /></xsl:for-each>
                                </td>
                              </tr>
                            </xsl:for-each>
                            <xsl:for-each select="n1:Invoice/cac:PaymentMeans/cbc:PaymentDueDate">
                              <tr>
                                <td class="invoiceDetailColor" style="white-space:nowrap;">Vade Tarihi</td>
                                <td class="doubleDot">:</td>
                                <td align="left">
                                  <xsl:for-each select="//n1:Invoice/cac:PaymentMeans/cbc:PaymentDueDate">
                                    <xsl:value-of select="substring(.,9,2)" />.<xsl:value-of select="substring(.,6,2)" />.<xsl:value-of select="substring(.,1,4)" /></xsl:for-each>
                                </td>
                              </tr>
                            </xsl:for-each>
                            <xsl:if test="//n1:Invoice/cbc:Note[contains(.,'Referans No')]">
                              <tr>
                                <td class="invoiceDetailColor" style="white-space:nowrap;">Referans No</td>
                                <td class="doubleDot">:</td>
                                <td>
                                  <xsl:value-of select="substring-after(//n1:Invoice/cbc:Note[contains(.,'Referans No :')],':')" />
                                </td>
                              </tr>
                            </xsl:if>
                            <xsl:if test="//n1:Invoice/cbc:Note[contains(.,'P/V:')]">
                              <tr>
                                <td class="noteLbl">P/V</td>
                                <td>:</td>
                                <td>
                                  <span>
                                    <xsl:value-of select="substring-after(//n1:Invoice/cbc:Note[contains(.,'P/V:')],'P/V: ')" />
                                  </span>
                                </td>
                              </tr>
                            </xsl:if>
                            <xsl:if test="n1:Invoice/cac:AdditionalDocumentReference[cbc:DocumentType='Plaka']/cbc:ID">
                              <tr>
                                <td class="invoiceDetailColor" style="white-space:nowrap;">Plaka No</td>
                                <td class="doubleDot">:</td>
                                <td>
                                  <xsl:value-of select="n1:Invoice/cac:AdditionalDocumentReference[cbc:DocumentType='Plaka']/cbc:ID" />
                                </td>
                              </tr>
                            </xsl:if>
                          </table>
                        </td>
                      </tr>
                    </table>
                  </td>
                </tr>
              </table>
            </td>
          </tr>
          <tr class="containerTr">
            <td>
              <table class="invoiceInfo">
                <tr>
                  <td width="300" align="right" valign="top">
                    <table id="customerPartyTable" align="left" border="0" height="50%">
                      <tbody>
                        <tr style="height:180px; ">
                          <td>
                            <table align="center" border="0" style="margin-bottom: 5px;border: 1px solid #6699FF; border-left-width:5px; width:100%;padding:5px;">
                              <tbody>
                                <tr align="left">
                                  <xsl:for-each select="n1:Invoice">
                                    <xsl:for-each select="cac:AccountingCustomerParty">
                                      <xsl:for-each select="cac:Party">
                                        <td style="width:469px; " align="left">
                                          <span style="font-weight:bold; ">
                                            <xsl:text>SAYIN</xsl:text>
                                          </span>
                                        </td>
                                      </xsl:for-each>
                                    </xsl:for-each>
                                  </xsl:for-each>
                                </tr>
                                <tr>
                                  <xsl:for-each select="n1:Invoice">
                                    <xsl:for-each select="cac:AccountingCustomerParty">
                                      <xsl:for-each select="cac:Party">
                                        <td style="width:469px; " align="left">
                                          <xsl:if test="cac:PartyName">
                                            <span style="font-weight:bold; ">
                                              <xsl:value-of select="cac:PartyName/cbc:Name" />
                                              <br />
                                              <br />
                                            </span>
                                          </xsl:if>
                                          <xsl:value-of select="$MusteriAdresi" />
                                          <br />
                                        </td>
                                      </xsl:for-each>
                                    </xsl:for-each>
                                  </xsl:for-each>
                                </tr>
                                <td style="width:469px; " align="left">
                                  <!-- <span class="lbl">Adres: </span> -->
                                  <xsl:if test="n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:PostalAddress/cbc:StreetName">
                                    <xsl:value-of select="n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:PostalAddress/cbc:StreetName" />
                                    <xsl:text> </xsl:text>
                                  </xsl:if>
                                  <xsl:if test="n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:PostalAddress/cbc:BuildingName">
                                    <xsl:value-of select="n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:PostalAddress/cbc:BuildingName" />
                                    <xsl:text> </xsl:text>
                                  </xsl:if>
                                  <xsl:if test="n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:PostalAddress/cbc:BuildingNumber">
                                    <xsl:text> No:</xsl:text>
                                    <xsl:value-of select="n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:PostalAddress/cbc:BuildingNumber" />
                                    <xsl:text> </xsl:text>
                                  </xsl:if>
                                  <xsl:if test="n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:PostalAddress/cbc:PostalZone">
                                    <xsl:value-of select="n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:PostalAddress/cbc:PostalZone" />
                                    <xsl:text> </xsl:text>
                                  </xsl:if>
                                  <xsl:value-of select="n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:PostalAddress/cbc:CitySubdivisionName" />
                                  <xsl:text>/</xsl:text>
                                  <xsl:value-of select="n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:PostalAddress/cbc:CityName" />
                                </td>
                                <xsl:for-each select="//n1:Invoice/cac:AccountingCustomerParty/cac:Party/cbc:WebsiteURI">
                                  <xsl:if test=". != ''">
                                    <tr align="left">
                                      <td>
                                        <xsl:text>Web Sitesi: </xsl:text>
                                        <xsl:value-of select="." />
                                      </td>
                                    </tr>
                                  </xsl:if>
                                </xsl:for-each>
                                <xsl:for-each select="//n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:Contact/cbc:ElectronicMail">
                                  <xsl:if test=". != ''">
                                    <tr align="left">
                                      <td>
                                        <xsl:text>E-Posta: </xsl:text>
                                        <xsl:value-of select="." />
                                      </td>
                                    </tr>
                                  </xsl:if>
                                </xsl:for-each>
                                <xsl:for-each select="n1:Invoice">
                                  <xsl:for-each select="cac:AccountingCustomerParty">
                                    <xsl:for-each select="cac:Party">
                                      <xsl:for-each select="cac:Contact">
                                        <xsl:if test="cbc:Telephone != '' or cbc:Telefax != ''">
                                          <tr align="left">
                                            <td style="width:469px; " align="left">
                                              <xsl:for-each select="cbc:Telephone">
                                                <xsl:if test=". != ''">
                                                  <span>
                                                    <xsl:text>Tel: </xsl:text>
                                                  </span>
                                                  <xsl:apply-templates />
                                                </xsl:if>
                                              </xsl:for-each>
                                              <xsl:for-each select="cbc:Telefax">
                                                <xsl:if test=". != ''">
                                                  <span>
                                                    <xsl:text> Fax: </xsl:text>
                                                  </span>
                                                  <xsl:apply-templates />
                                                </xsl:if>
                                              </xsl:for-each>
                                              <span>
                                                <xsl:text> </xsl:text>
                                              </span>
                                            </td>
                                          </tr>
                                        </xsl:if>
                                      </xsl:for-each>
                                    </xsl:for-each>
                                  </xsl:for-each>
                                </xsl:for-each>
                                <xsl:if test="//n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:PartyTaxScheme/cac:TaxScheme/cbc:Name != ''">
                                  <tr align="left">
                                    <td>
                                      <span>
                                        <xsl:text>Vergi Dairesi: </xsl:text>
                                        <xsl:value-of select="//n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:PartyTaxScheme/cac:TaxScheme/cbc:Name" />
                                      </span>
                                    </td>
                                  </tr>
                                </xsl:if>
                                <xsl:for-each select="//n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:PartyIdentification">
                                  <xsl:if test="cbc:ID != ''">
                                    <tr align="left">
                                      <td>
                                        <xsl:value-of select="cbc:ID/@schemeID" />
                                        <xsl:text>: </xsl:text>
                                        <xsl:value-of select="cbc:ID" />
                                      </td>
                                    </tr>
                                  </xsl:if>
                                </xsl:for-each>
                                <xsl:for-each select="//n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:AgentParty/cac:PartyIdentification">
                                  <xsl:if test="cbc:ID != ''">
                                    <tr align="left">
                                      <td>
                                        <xsl:value-of select="cbc:ID/@schemeID" />
                                        <xsl:text>: </xsl:text>
                                        <xsl:value-of select="cbc:ID" />
                                      </td>
                                    </tr>
                                  </xsl:if>
                                </xsl:for-each>
                              </tbody>
                            </table>
                            <div id="ettn">
                              <p style="text-align: left;">
                                <span class="lbl">ETTN: </span>
                                <xsl:value-of select="n1:Invoice/cbc:UUID" />
                              </p>
                            </div>
                          </td>
                        </tr>
                      </tbody>
                    </table>
                  </td>
                  <td width="300">
                  </td>
                  <td width="300">
                  </td>
                </tr>
              </table>
            </td>
          </tr>
          <xsl:if test="//n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:PartyIdentification/cbc:ID[@schemeID] ='7750409379'">
            <tr>
              <td>
                <br />
              </td>
            </tr>
            <tr>
              <td>
                <table border="1">
                  <tbody>
                    <tr>
                      <td style="width:105px; " align="left">
                        <span style="font-weight:bold; ">
                          <xsl:text>Sağlık Fatura Tipi:</xsl:text>
                        </span>
                      </td>
                      <td align="left">
                        <xsl:for-each select="n1:Invoice">
                          <xsl:for-each select="cbc:AccountingCost">
                            <xsl:apply-templates />
                          </xsl:for-each>
                        </xsl:for-each>
                      </td>
                    </tr>
                    <tr style="height:13px; ">
                      <td align="left">
                        <span style="font-weight:bold; ">
                          <xsl:text>Mükellef Kodu:</xsl:text>
                        </span>
                      </td>
                      <td align="left">
                        <xsl:for-each select="n1:Invoice">
                          <xsl:for-each select="cac:AdditionalDocumentReference[cbc:DocumentTypeCode='MUKELLEF_KODU']/cbc:DocumentType">
                            <xsl:apply-templates />
                          </xsl:for-each>
                        </xsl:for-each>
                      </td>
                    </tr>
                    <tr style="height:13px; ">
                      <td align="left">
                        <span style="font-weight:bold; ">
                          <xsl:text>Mükellef Adı:</xsl:text>
                        </span>
                      </td>
                      <td align="left">
                        <xsl:for-each select="n1:Invoice">
                          <xsl:for-each select="cac:AdditionalDocumentReference[cbc:DocumentTypeCode='MUKELLEF_ADI']/cbc:DocumentType">
                            <xsl:apply-templates />
                          </xsl:for-each>
                        </xsl:for-each>
                      </td>
                    </tr>
                    <tr style="height:13px; ">
                      <td align="left">
                        <span style="font-weight:bold; ">
                          <xsl:text>Dosya No:</xsl:text>
                        </span>
                      </td>
                      <td align="left">
                        <xsl:for-each select="n1:Invoice">
                          <xsl:for-each select="cac:AdditionalDocumentReference[cbc:DocumentTypeCode='DOSYA_NO']/cbc:DocumentType">
                            <xsl:apply-templates />
                          </xsl:for-each>
                        </xsl:for-each>
                      </td>
                    </tr>
                    <tr style="height:13px; ">
                      <td align="left">
                        <span style="font-weight:bold; ">
                          <xsl:text>Dönem:</xsl:text>
                        </span>
                      </td>
                      <td align="left">
                        <xsl:for-each select="n1:Invoice">
                          <xsl:for-each select="cac:InvoicePeriod/cbc:StartDate">
                            <xsl:apply-templates />
                          </xsl:for-each>
                          <span>
                            <xsl:text> / </xsl:text>
                          </span>
                          <xsl:for-each select="cac:InvoicePeriod/cbc:EndDate">
                            <xsl:apply-templates />
                          </xsl:for-each>
                        </xsl:for-each>
                      </td>
                    </tr>
                  </tbody>
                </table>
              </td>
            </tr>
            <tr>
              <td>
                <br />
              </td>
            </tr>
          </xsl:if>
          <tr>
            <div id="lineTableAligner">
              <span>
                <xsl:text> </xsl:text>
              </span>
            </div>
          </tr>
          <tr>
            <td>
              <table border="1" id="lineTable" width="900">
                <tbody>
                  <tr id="lineTableHeader">
                    <th style="width:3%">Sıra No</th>
                    <xsl:if test="//n1:Invoice/cac:InvoiceLine/cac:Item/cbc:BrandName and&#xD;&#xA;												  //n1:Invoice/cbc:InvoiceTypeCode!='KOMISYONCU'">
                      <th style="width:10%">Müstahsil Marka Bilgileri</th>
                    </xsl:if>
                    <xsl:if test="//n1:Invoice/cac:InvoiceLine/cac:Item/cac:SellersItemIdentification">
                      <th style="width:3%">Ürün Kodu</th>
                    </xsl:if>
                    <th style="width:15%">Ürün Adı</th>
                    <xsl:if test="//n1:Invoice/cac:InvoiceLine/cac:Item/cac:AdditionalItemIdentification/cbc:ID[@schemeID='KUNYENO']">
                      <th style="width:10%">Künye</th>
                    </xsl:if>
                    <xsl:if test="//n1:Invoice/cac:InvoiceLine/cbc:Note">
                      <th style="width:5%">Kap</th>
                      <th style="width:7%">Daralı</th>
                      <th style="width:5%">Dara</th>
                    </xsl:if>
                    <th style="width:7%">Miktar</th>
                    <th style="width:2%">Birim</th>
                    <th style="width:7%">Birim Fiyat</th>
                    <xsl:if test="//n1:Invoice/cac:InvoiceLine/cac:AllowanceCharge/cbc:Amount &gt;0 and&#xD;&#xA;												  //n1:Invoice/cbc:InvoiceTypeCode!='KOMISYONCU'">
                      <th style="width:5%">İsk. %</th>
                      <th style="width:7%">İskonto Tutarı</th>
                    </xsl:if>
                    <th style="width:5%">KDV Oranı</th>
                    <th style="width:8%">KDV Tutarı</th>
                    <xsl:if test="//n1:Invoice/cbc:InvoiceTypeCode!='KOMISYONCU'">
                      <th style="width:7%">Diğer Vergiler</th>
                    </xsl:if>
                    <th style="width:10%">Mal Hizmet Tutarı</th>
                  </tr>
                  <xsl:for-each select="n1:Invoice/cac:InvoiceLine">
                    <tr>
                      <td align="left">
                        <xsl:value-of select="./cbc:ID" />
                      </td>
                      <xsl:if test="//n1:Invoice/cac:InvoiceLine/cac:Item/cbc:BrandName and&#xD;&#xA;													  //n1:Invoice/cbc:InvoiceTypeCode!='KOMISYONCU'">
                        <td align="left">
                          <xsl:value-of select="./cac:Item/cbc:BrandName" />
                        </td>
                      </xsl:if>
                      <xsl:if test="//n1:Invoice/cac:InvoiceLine/cac:Item/cac:SellersItemIdentification">
                        <td align="left">
                          <xsl:value-of select="./cac:Item/cac:SellersItemIdentification/cbc:ID" />
                        </td>
                      </xsl:if>
                      <td align="left">
                        <xsl:value-of select="./cac:Item/cbc:Name" />
                      </td>
                      <xsl:if test="//n1:Invoice/cac:InvoiceLine/cac:Item/cac:AdditionalItemIdentification/cbc:ID[@schemeID='KUNYENO']">
                        <td>
                          <xsl:value-of select="./cac:Item/cac:AdditionalItemIdentification/cbc:ID[@schemeID='KUNYENO']" />
                        </td>
                      </xsl:if>
                      <xsl:if test="//n1:Invoice/cac:InvoiceLine/cbc:Note and not(contains(.,'Not:'))">
                        <xsl:variable name="pText" select="./cbc:Note" />
                        <xsl:variable name="pTrim" select="normalize-space($pText)" />
                        <xsl:variable name="pAdet" select="substring-before(concat($pTrim,' '),' ')" />
                        <xsl:variable name="pDaralıDara" select="substring-after(concat($pTrim,' '),' ')" />
                        <xsl:variable name="pDaralı" select="substring-before(concat($pDaralıDara,' '),' ')" />
                        <xsl:variable name="pDara" select="substring-after(concat($pDaralıDara,' '),' ')" />
                        <td align="center">
                          <xsl:value-of select="$pAdet" />
                        </td>
                        <td align="right">
                          <xsl:value-of select="$pDaralı" />
                        </td>
                        <td align="right">
                          <xsl:value-of select="$pDara" />
                        </td>
                      </xsl:if>
                      <td align="right">
                        <xsl:value-of select="./cbc:InvoicedQuantity" />
                        <!--<xsl:value-of select="format-number(./cbc:InvoicedQuantity, '###.##0,0##', 'european')"/>-->
                      </td>
                      <td align="center">
                        <xsl:if test="./cbc:InvoicedQuantity/@unitCode">
                          <xsl:for-each select="./cbc:InvoicedQuantity">
                            <xsl:text />
                            <xsl:choose>
                              <xsl:when test="@unitCode  = '26'">
                                <xsl:text>Ton</xsl:text>
                              </xsl:when>
                              <xsl:when test="@unitCode  = 'BX'">
                                <xsl:text>Kutu</xsl:text>
                              </xsl:when>
                              <xsl:when test="@unitCode  = 'NIU'">
                                <xsl:text>Adet</xsl:text>
                              </xsl:when>
                              <xsl:when test="@unitCode  = 'EA'">
                                <xsl:text>Adet</xsl:text>
                              </xsl:when>
                              <xsl:when test="@unitCode  = 'KGM'">
                                <xsl:text>KG</xsl:text>
                              </xsl:when>
                              <xsl:when test="@unitCode  = 'BE'">
                                <xsl:text>Bağ</xsl:text>
                              </xsl:when>
                              <xsl:when test="@unitCode  = 'KJO'">
                                <xsl:text>kJ</xsl:text>
                              </xsl:when>
                              <xsl:when test="@unitCode  = 'GRM'">
                                <xsl:text>G</xsl:text>
                              </xsl:when>
                              <xsl:when test="@unitCode  = 'MGM'">
                                <xsl:text>MG</xsl:text>
                              </xsl:when>
                              <xsl:when test="@unitCode  = 'NT'">
                                <xsl:text>Net Ton</xsl:text>
                              </xsl:when>
                              <xsl:when test="@unitCode  = 'GT'">
                                <xsl:text>GT</xsl:text>
                              </xsl:when>
                              <xsl:when test="@unitCode  = 'MTR'">
                                <xsl:text>M</xsl:text>
                              </xsl:when>
                              <xsl:when test="@unitCode  = 'MMT'">
                                <xsl:text>MM</xsl:text>
                              </xsl:when>
                              <xsl:when test="@unitCode  = 'KTM'">
                                <xsl:text>KM</xsl:text>
                              </xsl:when>
                              <xsl:when test="@unitCode  = 'MLT'">
                                <xsl:text>ML</xsl:text>
                              </xsl:when>
                              <xsl:when test="@unitCode  = 'MIL'">
                                <xsl:text>MIL</xsl:text>
                              </xsl:when>
                              <xsl:when test="@unitCode  = 'MMQ'">
                                <xsl:text>MM3</xsl:text>
                              </xsl:when>
                              <xsl:when test="@unitCode  = 'CLT'">
                                <xsl:text>CL</xsl:text>
                              </xsl:when>
                              <xsl:when test="@unitCode  = 'CMK'">
                                <xsl:text>CM2</xsl:text>
                              </xsl:when>
                              <xsl:when test="@unitCode  = 'CMQ'">
                                <xsl:text>CM3</xsl:text>
                              </xsl:when>
                              <xsl:when test="@unitCode  = 'CMT'">
                                <xsl:text>CM</xsl:text>
                              </xsl:when>
                              <xsl:when test="@unitCode  = 'MTK'">
                                <xsl:text>M2</xsl:text>
                              </xsl:when>
                              <xsl:when test="@unitCode  = 'MTQ'">
                                <xsl:text>M3</xsl:text>
                              </xsl:when>
                              <xsl:when test="@unitCode  = 'DAY'">
                                <xsl:text>Gün</xsl:text>
                              </xsl:when>
                              <xsl:when test="@unitCode  = 'MON'">
                                <xsl:text>Ay</xsl:text>
                              </xsl:when>
                              <xsl:when test="@unitCode  = 'PA'">
                                <xsl:text>Paket</xsl:text>
                              </xsl:when>
                              <xsl:when test="@unitCode  = 'KWH'">
                                <xsl:text>KWH</xsl:text>
                              </xsl:when>
                              <xsl:when test="@unitCode  = 'CT'">
                                <xsl:text>Karton</xsl:text>
                              </xsl:when>
                              <xsl:when test="@unitCode  = 'TNE'">
                                <xsl:text>Ton</xsl:text>
                              </xsl:when>
                              <xsl:when test="@unitCode  = 'CS'">
                                <xsl:text>CS</xsl:text>
                              </xsl:when>
                              <xsl:when test="@unitCode  = 'PK'">
                                <xsl:text>Paket</xsl:text>
                              </xsl:when>
                              <xsl:when test="@unitCode  = '15'">
                                <xsl:text>Paket</xsl:text>
                              </xsl:when>
                              <xsl:when test="@unitCode  = 'PK'">
                                <xsl:text>Stick</xsl:text>
                              </xsl:when>
                            </xsl:choose>
                          </xsl:for-each>
                        </xsl:if>
                      </td>
                      <td align="right">
                        <xsl:for-each select="./cac:Price/cbc:PriceAmount">
                          <xsl:value-of select="format-number(., '###.##0,000', 'european')" />
                          <xsl:if test="@currencyID">
                            <xsl:text>
                            </xsl:text>
                            <xsl:choose>
                              <xsl:when test="@currencyID = 'TRL' or @currencyID = 'TRY'">
                                <xsl:text>TL</xsl:text>
                              </xsl:when>
                              <xsl:otherwise>
                                <xsl:value-of select="@currencyID" />
                              </xsl:otherwise>
                            </xsl:choose>
                          </xsl:if>
                        </xsl:for-each>
                      </td>
                      <xsl:if test="//n1:Invoice/cac:InvoiceLine/cac:AllowanceCharge/cbc:Amount &gt;0 and&#xD;&#xA;													  //n1:Invoice/cbc:InvoiceTypeCode!='KOMISYONCU'">
                        <td align="right">
                          <xsl:if test="./cac:AllowanceCharge/cbc:MultiplierFactorNumeric">
                            <xsl:value-of select="format-number(./cac:AllowanceCharge/cbc:MultiplierFactorNumeric * 100, '###.##0,00', 'european')" />
                          </xsl:if>
                        </td>
                        <td align="right">
                          <xsl:for-each select="./cac:AllowanceCharge/cbc:Amount">
                            <xsl:call-template name="Curr_Type" />
                          </xsl:for-each>
                        </td>
                      </xsl:if>
                      <td align="right">
                        <xsl:for-each select="./cac:TaxTotal">
                          <xsl:for-each select="cac:TaxSubtotal/cac:TaxCategory/cac:TaxScheme">
                            <xsl:if test="cbc:TaxTypeCode='0015' ">
                              <xsl:if test="../../cbc:Percent">
                                <xsl:value-of select="format-number(../../cbc:Percent, '###.##0,00', 'european')" />
                              </xsl:if>
                            </xsl:if>
                          </xsl:for-each>
                        </xsl:for-each>
                      </td>
                      <td align="right">
                        <xsl:for-each select="./cac:TaxTotal">
                          <xsl:for-each select="cac:TaxSubtotal/cac:TaxCategory/cac:TaxScheme">
                            <xsl:if test="cbc:TaxTypeCode='0015' ">
                              <xsl:for-each select="../../cbc:TaxAmount">
                                <xsl:call-template name="Curr_Type" />
                              </xsl:for-each>
                            </xsl:if>
                          </xsl:for-each>
                        </xsl:for-each>
                      </td>
                      <xsl:if test="//n1:Invoice/cbc:InvoiceTypeCode!='KOMISYONCU'">
                        <td style="font-size: xx-small" align="left">
                          <span>
                            <xsl:text> </xsl:text>
                            <xsl:for-each select="./cac:TaxTotal/cac:TaxSubtotal/cac:TaxCategory/cac:TaxScheme">
                              <xsl:if test="cbc:TaxTypeCode!='0015' ">
                                <xsl:text>
                                </xsl:text>
                                <xsl:value-of select="cbc:Name" />
                                <xsl:if test="../../cbc:Percent">
                                  <xsl:text> (%</xsl:text>
                                  <xsl:value-of select="format-number(../../cbc:Percent, '###.##0,00', 'european')" />
                                  <xsl:text>)=</xsl:text>
                                </xsl:if>
                                <xsl:value-of select="format-number(../../cbc:TaxAmount, '###.##0,00', 'european')" />
                                <xsl:if test="../../cbc:TaxAmount/@currencyID">
                                  <xsl:text>TL</xsl:text>
                                </xsl:if>
                              </xsl:if>
                            </xsl:for-each>
                          </span>
                        </td>
                      </xsl:if>
                      <td align="right">
                        <xsl:for-each select="./cbc:LineExtensionAmount">
                          <xsl:call-template name="Curr_Type" />
                        </xsl:for-each>
                      </td>
                    </tr>
                  </xsl:for-each>
                  <tr>
                    <td>
                    </td>
                    <xsl:if test="//n1:Invoice/cac:InvoiceLine/cac:Item/cbc:BrandName and&#xD;&#xA;													  //n1:Invoice/cbc:InvoiceTypeCode!='KOMISYONCU'">
                      <td>
                      </td>
                    </xsl:if>
                    <xsl:if test="//n1:Invoice/cac:InvoiceLine/cac:Item/cac:SellersItemIdentification">
                      <td>
                      </td>
                    </xsl:if>
                    <td align="center">
                      <span id="totalTable"> Toplam :</span>
                    </td>
                    <xsl:if test="//n1:Invoice/cac:InvoiceLine/cac:Item/cac:AdditionalItemIdentification/cbc:ID[@schemeID='KUNYENO']">
                      <td>
                      </td>
                    </xsl:if>
                    <xsl:if test="//n1:Invoice/cac:InvoiceLine/cbc:Note and not(contains(.,'Not:'))">
                      <td align="center">
                        <xsl:if test="//n1:Invoice/cbc:Note[contains(.,'Toplam Kap')]">
                          <span id="totalTable">
                            <xsl:value-of select="substring-after(//n1:Invoice/cbc:Note[contains(.,'Toplam Kap    :')],':')" />
                          </span>
                        </xsl:if>
                      </td>
                      <td align="right">
                        <xsl:if test="//n1:Invoice/cbc:Note[contains(.,'Toplam Darali')]">
                          <span id="totalTable">
                            <xsl:value-of select="substring-after(//n1:Invoice/cbc:Note[contains(.,'Toplam Darali :')],':')" />
                          </span>
                        </xsl:if>
                      </td>
                      <td align="right">
                        <xsl:if test="//n1:Invoice/cbc:Note[contains(.,'Toplam Dara')]">
                          <span id="totalTable">
                            <xsl:value-of select="substring-after(//n1:Invoice/cbc:Note[contains(.,'Toplam Dara   :')],':')" />
                          </span>
                        </xsl:if>
                      </td>
                    </xsl:if>
                    <td align="right">
                      <xsl:if test="//n1:Invoice/cbc:Note[contains(.,'Toplam Miktar')]">
                        <span id="totalTable">
                          <xsl:value-of select="substring-after(//n1:Invoice/cbc:Note[contains(.,'Toplam Miktar :')],':')" />
                        </span>
                      </xsl:if>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                    <xsl:if test="//n1:Invoice/cac:InvoiceLine/cac:AllowanceCharge/cbc:Amount &gt;0 and&#xD;&#xA;													  //n1:Invoice/cbc:InvoiceTypeCode!='KOMISYONCU'">
                      <td>
                      </td>
                      <td>
                      </td>
                    </xsl:if>
                    <td>
                    </td>
                    <td>
                    </td>
                    <xsl:if test="//n1:Invoice/cbc:InvoiceTypeCode!='KOMISYONCU'">
                      <td>
                      </td>
                    </xsl:if>
                    <td>
                    </td>
                  </tr>
                </tbody>
              </table>
            </td>
          </tr>
          <tr class="containerTr">
            <td id="invoiceTotal">
              <table width="900" style="border-collapse:collapse;">
                <tr>
                  <td valign="top">
                    <xsl:if test="(//n1:Invoice/cbc:ProfileID='HKS' or //n1:Invoice/cbc:ProfileID='EARSIVFATURA') and //n1:Invoice/cbc:InvoiceTypeCode='KOMISYONCU'">
                      <table width="400" class="allowanceChargeTable">
                        <tr align="center" border="0">
                          <th colspan="3" style="text-align:center;">
                            <xsl:text>Masraflar</xsl:text>
                          </th>
                        </tr>
                        <xsl:for-each select="n1:Invoice/cac:AllowanceCharge">
                          <xsl:if test="cbc:AllowanceChargeReason = 'HKSKOMISYON'">
                            <tr align="left">
                              <td align="right" width="200px">
                                <span style="font-weight:bold; ">
                                  <xsl:text>Komisyon - %</xsl:text>
                                </span>
                              </td>
                              <td style="width:81px; " align="right">
                                <xsl:for-each select="cbc:Amount">
                                  <xsl:call-template name="Curr_Type" />
                                </xsl:for-each>
                              </td>
                              <td style="width:81px; " align="right">
                                <xsl:for-each select="cbc:MultiplierFactorNumeric">
                                  <xsl:text> %</xsl:text>
                                  <xsl:call-template name="Curr_Type" />
                                </xsl:for-each>
                              </td>
                            </tr>
                          </xsl:if>
                          <xsl:if test="cbc:AllowanceChargeReason = 'HKSKOMISYONKDV'">
                            <tr align="right">
                              <td align="right" width="200px">
                                <span style="font-weight:bold; ">
                                  <xsl:text>Komisyon KDV - %</xsl:text>
                                </span>
                              </td>
                              <td style="width:81px; " align="right">
                                <xsl:for-each select="cbc:Amount">
                                  <xsl:call-template name="Curr_Type" />
                                </xsl:for-each>
                              </td>
                              <td style="width:81px; " align="right">
                                <xsl:for-each select="cbc:MultiplierFactorNumeric">
                                  <xsl:text> %</xsl:text>
                                  <xsl:call-template name="Curr_Type" />
                                </xsl:for-each>
                              </td>
                            </tr>
                          </xsl:if>
                          <xsl:if test="cbc:AllowanceChargeReason = 'HKSNAVLUN'">
                            <tr align="right">
                              <td align="right" width="200px">
                                <span style="font-weight:bold; ">
                                  <xsl:text>Navlun - %</xsl:text>
                                </span>
                              </td>
                              <td style="width:81px; " align="right">
                                <xsl:for-each select="cbc:Amount">
                                  <xsl:call-template name="Curr_Type" />
                                </xsl:for-each>
                              </td>
                              <td style="width:81px; " align="right">
                                <xsl:for-each select="cbc:MultiplierFactorNumeric">
                                  <xsl:text> %</xsl:text>
                                  <xsl:call-template name="Curr_Type" />
                                </xsl:for-each>
                              </td>
                            </tr>
                          </xsl:if>
                          <xsl:if test="cbc:AllowanceChargeReason = 'HKSNAVLUNKDV'">
                            <tr align="right">
                              <td align="right" width="200px">
                                <span style="font-weight:bold; ">
                                  <xsl:text>Navlun KDV - %</xsl:text>
                                </span>
                              </td>
                              <td style="width:81px; " align="right">
                                <xsl:for-each select="cbc:Amount">
                                  <xsl:call-template name="Curr_Type" />
                                </xsl:for-each>
                              </td>
                              <td style="width:81px; " align="right">
                                <xsl:for-each select="cbc:MultiplierFactorNumeric">
                                  <xsl:text> %</xsl:text>
                                  <xsl:call-template name="Curr_Type" />
                                </xsl:for-each>
                              </td>
                            </tr>
                          </xsl:if>
                          <xsl:if test="cbc:AllowanceChargeReason = 'HKSHAMMALIYE'">
                            <tr align="right">
                              <td align="right" width="200px">
                                <span style="font-weight:bold; ">
                                  <xsl:text>Hammaliye - %</xsl:text>
                                </span>
                              </td>
                              <td style="width:81px; " align="right">
                                <xsl:for-each select="cbc:Amount">
                                  <xsl:call-template name="Curr_Type" />
                                </xsl:for-each>
                              </td>
                              <td style="width:81px; " align="right">
                                <xsl:for-each select="cbc:MultiplierFactorNumeric">
                                  <xsl:text> %</xsl:text>
                                  <xsl:call-template name="Curr_Type" />
                                </xsl:for-each>
                              </td>
                            </tr>
                          </xsl:if>
                          <xsl:if test="cbc:AllowanceChargeReason = 'HKSHAMMALIYEKDV'">
                            <tr align="right">
                              <td align="right" width="200px">
                                <span style="font-weight:bold; ">
                                  <xsl:text>Hammaliye KDV - %</xsl:text>
                                </span>
                              </td>
                              <td style="width:81px; " align="right">
                                <xsl:for-each select="cbc:Amount">
                                  <xsl:call-template name="Curr_Type" />
                                </xsl:for-each>
                              </td>
                              <td style="width:81px; " align="right">
                                <xsl:for-each select="cbc:MultiplierFactorNumeric">
                                  <xsl:text> %</xsl:text>
                                  <xsl:call-template name="Curr_Type" />
                                </xsl:for-each>
                              </td>
                            </tr>
                          </xsl:if>
                          <xsl:if test="cbc:AllowanceChargeReason = 'HKSNAKLIYE'">
                            <tr align="right">
                              <td align="right" width="200px">
                                <span style="font-weight:bold; ">
                                  <xsl:text>Nakliye - %</xsl:text>
                                </span>
                              </td>
                              <td style="width:81px; " align="right">
                                <xsl:for-each select="cbc:Amount">
                                  <xsl:call-template name="Curr_Type" />
                                </xsl:for-each>
                              </td>
                              <td style="width:81px; " align="right">
                                <xsl:for-each select="cbc:MultiplierFactorNumeric">
                                  <xsl:text> %</xsl:text>
                                  <xsl:call-template name="Curr_Type" />
                                </xsl:for-each>
                              </td>
                            </tr>
                          </xsl:if>
                          <xsl:if test="cbc:AllowanceChargeReason = 'HKSNAKLIYEKDV'">
                            <tr align="right">
                              <td align="right" width="200px">
                                <span style="font-weight:bold; ">
                                  <xsl:text>Nakliye KDV - %</xsl:text>
                                </span>
                              </td>
                              <td style="width:81px; " align="right">
                                <xsl:for-each select="cbc:Amount">
                                  <xsl:call-template name="Curr_Type" />
                                </xsl:for-each>
                              </td>
                              <td style="width:81px; " align="right">
                                <xsl:for-each select="cbc:MultiplierFactorNumeric">
                                  <xsl:text> %</xsl:text>
                                  <xsl:call-template name="Curr_Type" />
                                </xsl:for-each>
                              </td>
                            </tr>
                          </xsl:if>
                          <xsl:if test="cbc:AllowanceChargeReason = 'HKSGVTEVKIFAT'">
                            <tr align="right">
                              <td align="right" width="200px">
                                <span style="font-weight:bold; ">
                                  <xsl:text>G.V. Tevkifat - %</xsl:text>
                                </span>
                              </td>
                              <td style="width:81px; " align="right">
                                <xsl:for-each select="cbc:Amount">
                                  <xsl:call-template name="Curr_Type" />
                                </xsl:for-each>
                              </td>
                              <td style="width:81px; " align="right">
                                <xsl:for-each select="cbc:MultiplierFactorNumeric">
                                  <xsl:text> %</xsl:text>
                                  <xsl:call-template name="Curr_Type" />
                                </xsl:for-each>
                              </td>
                            </tr>
                          </xsl:if>
                          <xsl:if test="cbc:AllowanceChargeReason = 'HKSBAGKURTEVKIFAT'">
                            <tr align="right">
                              <td align="right" width="200px">
                                <span style="font-weight:bold; ">
                                  <xsl:text>Bağkur Tevkifat - %</xsl:text>
                                </span>
                              </td>
                              <td style="width:81px; " align="right">
                                <xsl:for-each select="cbc:Amount">
                                  <xsl:call-template name="Curr_Type" />
                                </xsl:for-each>
                              </td>
                              <td style="width:81px; " align="right">
                                <xsl:for-each select="cbc:MultiplierFactorNumeric">
                                  <xsl:text> %</xsl:text>
                                  <xsl:call-template name="Curr_Type" />
                                </xsl:for-each>
                              </td>
                            </tr>
                          </xsl:if>
                          <xsl:if test="cbc:AllowanceChargeReason = 'HKSRUSUM'">
                            <tr align="right">
                              <td align="right" width="200px">
                                <span style="font-weight:bold; ">
                                  <xsl:text>Rüsum - %</xsl:text>
                                </span>
                              </td>
                              <td style="width:81px; " align="right">
                                <xsl:for-each select="cbc:Amount">
                                  <xsl:call-template name="Curr_Type" />
                                </xsl:for-each>
                              </td>
                              <td style="width:81px; " align="right">
                                <xsl:for-each select="cbc:MultiplierFactorNumeric">
                                  <xsl:text> %</xsl:text>
                                  <xsl:call-template name="Curr_Type" />
                                </xsl:for-each>
                              </td>
                            </tr>
                          </xsl:if>
                          <xsl:if test="cbc:AllowanceChargeReason = 'HKSRUSUMKDV'">
                            <tr align="right">
                              <td align="right" width="200px">
                                <span style="font-weight:bold; ">
                                  <xsl:text>Rüsum KDV - %</xsl:text>
                                </span>
                              </td>
                              <td style="width:81px; " align="right">
                                <xsl:for-each select="cbc:Amount">
                                  <xsl:call-template name="Curr_Type" />
                                </xsl:for-each>
                              </td>
                              <td style="width:81px; " align="right">
                                <xsl:for-each select="cbc:MultiplierFactorNumeric">
                                  <xsl:text> %</xsl:text>
                                  <xsl:call-template name="Curr_Type" />
                                </xsl:for-each>
                              </td>
                            </tr>
                          </xsl:if>
                          <xsl:if test="cbc:AllowanceChargeReason = 'HKSTICBORSASI'">
                            <tr align="right">
                              <td align="right" width="200px">
                                <span style="font-weight:bold; ">
                                  <xsl:text>Ticaret Borsası - %</xsl:text>
                                </span>
                              </td>
                              <td style="width:81px; " align="right">
                                <xsl:for-each select="cbc:Amount">
                                  <xsl:call-template name="Curr_Type" />
                                </xsl:for-each>
                              </td>
                              <td style="width:81px; " align="right">
                                <xsl:for-each select="cbc:MultiplierFactorNumeric">
                                  <xsl:text> %</xsl:text>
                                  <xsl:call-template name="Curr_Type" />
                                </xsl:for-each>
                              </td>
                            </tr>
                          </xsl:if>
                          <xsl:if test="cbc:AllowanceChargeReason = 'HKSTICBORSASIKDV'">
                            <tr align="right">
                              <td align="right" width="200px">
                                <span style="font-weight:bold; ">
                                  <xsl:text>Ticaret Borsası KDV - %</xsl:text>
                                </span>
                              </td>
                              <td style="width:81px; " align="right">
                                <xsl:for-each select="cbc:Amount">
                                  <xsl:call-template name="Curr_Type" />
                                </xsl:for-each>
                              </td>
                              <td style="width:81px; " align="right">
                                <xsl:for-each select="cbc:MultiplierFactorNumeric">
                                  <xsl:text> %</xsl:text>
                                  <xsl:call-template name="Curr_Type" />
                                </xsl:for-each>
                              </td>
                            </tr>
                          </xsl:if>
                          <xsl:if test="cbc:AllowanceChargeReason = 'HKSMILLISAVUNMAFON'">
                            <tr align="right">
                              <td align="right" width="200px">
                                <span style="font-weight:bold; ">
                                  <xsl:text>Milli Savunma Fon - %</xsl:text>
                                </span>
                              </td>
                              <td style="width:81px; " align="right">
                                <xsl:for-each select="cbc:Amount">
                                  <xsl:call-template name="Curr_Type" />
                                </xsl:for-each>
                              </td>
                              <td style="width:81px; " align="right">
                                <xsl:for-each select="cbc:MultiplierFactorNumeric">
                                  <xsl:text> %</xsl:text>
                                  <xsl:call-template name="Curr_Type" />
                                </xsl:for-each>
                              </td>
                            </tr>
                          </xsl:if>
                          <xsl:if test="cbc:AllowanceChargeReason = 'HKSMSFONKDV'">
                            <tr align="right">
                              <td align="right" width="200px">
                                <span style="font-weight:bold; ">
                                  <xsl:text>Milli Savunma Fon KDV - %</xsl:text>
                                </span>
                              </td>
                              <td style="width:81px; " align="right">
                                <xsl:for-each select="cbc:Amount">
                                  <xsl:call-template name="Curr_Type" />
                                </xsl:for-each>
                              </td>
                              <td style="width:81px; " align="right">
                                <xsl:for-each select="cbc:MultiplierFactorNumeric">
                                  <xsl:text> %</xsl:text>
                                  <xsl:call-template name="Curr_Type" />
                                </xsl:for-each>
                              </td>
                            </tr>
                          </xsl:if>
                          <xsl:if test="cbc:AllowanceChargeReason = 'HKSDIGERMASRAFLAR'">
                            <tr align="right">
                              <td align="right" width="200px">
                                <span style="font-weight:bold; ">
                                  <xsl:text>Diğer Masraflar - %</xsl:text>
                                </span>
                              </td>
                              <td style="width:81px; " align="right">
                                <xsl:for-each select="cbc:Amount">
                                  <xsl:call-template name="Curr_Type" />
                                </xsl:for-each>
                              </td>
                              <td style="width:81px; " align="right">
                                <xsl:for-each select="cbc:MultiplierFactorNumeric">
                                  <xsl:text> %</xsl:text>
                                  <xsl:call-template name="Curr_Type" />
                                </xsl:for-each>
                              </td>
                            </tr>
                          </xsl:if>
                          <xsl:if test="cbc:AllowanceChargeReason = 'HKSDIGERKDV'">
                            <tr align="right">
                              <td align="right" width="200px">
                                <span style="font-weight:bold; ">
                                  <xsl:text>Diğer KDV - %</xsl:text>
                                </span>
                              </td>
                              <td style="width:81px; " align="right">
                                <xsl:for-each select="cbc:Amount">
                                  <xsl:call-template name="Curr_Type" />
                                </xsl:for-each>
                              </td>
                              <td style="width:81px; " align="right">
                                <xsl:for-each select="cbc:MultiplierFactorNumeric">
                                  <xsl:text> %</xsl:text>
                                  <xsl:call-template name="Curr_Type" />
                                </xsl:for-each>
                              </td>
                            </tr>
                          </xsl:if>
                        </xsl:for-each>
                      </table>
                    </xsl:if>
                  </td>
                  <td valign="top">
                    <table align="right" width="400" id="budgetContainerTable">
                      <tr>
                        <th>Mal Hizmet Toplam Tutarı</th>
                        <td>
                          <xsl:for-each select="n1:Invoice/cac:LegalMonetaryTotal/cbc:LineExtensionAmount">
                            <xsl:call-template name="Curr_Type" />
                          </xsl:for-each>
                        </td>
                      </tr>
                      <xsl:if test="$legalMonetary &gt;0 or $linediscount &gt;0 ">
                        <tr>
                          <th>Toplam İskonto</th>
                          <td>
                            <xsl:value-of select="format-number($linediscount, '###.##0,00', 'european')" />
                            <xsl:for-each select=".">
                              <xsl:call-template name="Curr_Type_Only" />
                            </xsl:for-each>
                          </td>
                        </tr>
                      </xsl:if>
                      <xsl:for-each select="//n1:Invoice/cac:TaxTotal/cac:TaxSubtotal">
                        <xsl:sort select="cbc:Percent" data-type="number" />
                        <tr>
                          <th>
                            <xsl:value-of select="cac:TaxCategory/cac:TaxScheme/cbc:Name" /> %<xsl:value-of select="cbc:Percent" /> (Matrah: <xsl:value-of select="format-number(cbc:TaxableAmount, '###.##0,00', 'european')" />)
											  </th>
                          <td>
                            <xsl:for-each select="cbc:TaxAmount">
                              <xsl:call-template name="Curr_Type" />
                            </xsl:for-each>
                          </td>
                        </tr>
                      </xsl:for-each>
                      <tr>
                        <th>
                          <xsl:choose>
                            <xsl:when test="count(n1:Invoice/cac:TaxTotal/cac:TaxSubtotal/cac:TaxCategory/cac:TaxScheme[TaxTypeCode='9015'])&gt;0">
                              <xsl:text>Tevkifat </xsl:text>
                            </xsl:when>
                            <xsl:otherwise>
                              <xsl:text>Vergiler </xsl:text>
                            </xsl:otherwise>
                          </xsl:choose>
                          <xsl:text>Dahil Toplam Tutar</xsl:text>
                        </th>
                        <td>
                          <xsl:for-each select="n1:Invoice/cac:LegalMonetaryTotal/cbc:TaxInclusiveAmount">
                            <xsl:call-template name="Curr_Type" />
                          </xsl:for-each>
                        </td>
                      </tr>
                      <xsl:if test="(//n1:Invoice/cbc:ProfileID='HKS' or //n1:Invoice/cbc:ProfileID='EARSIVFATURA') and //n1:Invoice/cbc:InvoiceTypeCode='KOMISYONCU'">
                        <tr>
                          <th>
                            <xsl:text>Toplam Masraflar</xsl:text>
                          </th>
                          <td>
                            <xsl:for-each select="n1:Invoice/cac:LegalMonetaryTotal/cbc:ChargeTotalAmount">
                              <xsl:call-template name="Curr_Type" />
                            </xsl:for-each>
                          </td>
                        </tr>
                      </xsl:if>
                      <xsl:for-each select="n1:Invoice/cac:WithholdingTaxTotal/cac:TaxSubtotal[starts-with(./cac:TaxCategory/cac:TaxScheme/cbc:TaxTypeCode,'6')]">
                        <tr>
                          <th>
                            <xsl:text>KDV Tevkifat Tutarı (</xsl:text>
                            <xsl:value-of select="./cac:TaxCategory/cac:TaxScheme/cbc:Name" /> - 
														<xsl:value-of select="./cac:TaxCategory/cac:TaxScheme/cbc:TaxTypeCode" />)<xsl:text>(%</xsl:text><xsl:value-of select="cbc:Percent" /><xsl:text>)</xsl:text>:															
													</th>
                          <td align="right">
                            <xsl:value-of select="format-number(cbc:TaxAmount, '###.##0,00', 'european')" />
                            <span>
                              <xsl:if test="//n1:Invoice/cbc:DocumentCurrencyCode = 'TRY' or //n1:Invoice/cbc:DocumentCurrencyCode = 'TRL'">
                                <xsl:text> TL</xsl:text>
                              </xsl:if>
                              <xsl:if test="//n1:Invoice/cbc:DocumentCurrencyCode != 'TRY' and //n1:Invoice/cbc:DocumentCurrencyCode != 'TRL'">
                                <xsl:text>
                                </xsl:text>
                                <xsl:value-of select="//n1:Invoice/cbc:DocumentCurrencyCode" />
                              </xsl:if>
                            </span>
                          </td>
                        </tr>
                      </xsl:for-each>
                      <tr>
                        <th>Fatura Tutarı</th>
                        <td>
                          <xsl:for-each select="n1:Invoice/cac:LegalMonetaryTotal/cbc:PayableAmount">
                            <xsl:call-template name="Curr_Type" />
                          </xsl:for-each>
                        </td>
                      </tr>
                      <xsl:if test="//n1:Invoice/cbc:Note[contains(.,'Rehin Dahil Toplam Tutar')]">
                        <tr>
                          <th>Rehin Dahil Toplam Tutar</th>
                          <td>
                            <xsl:value-of select="substring-after(//n1:Invoice/cbc:Note[contains(.,'Rehin Dahil Toplam Tutar :')],':')" />
                            <xsl:for-each select=".">
                              <xsl:call-template name="Curr_Type_Only" />
                            </xsl:for-each>
                          </td>
                        </tr>
                      </xsl:if>
                      <xsl:if test="//n1:Invoice/cbc:Note[contains(.,'İadeli Kap')]">
                        <tr>
                          <th>İadeli Kap</th>
                          <td>
                            <xsl:value-of select="substring-after(//n1:Invoice/cbc:Note[contains(.,'İadeli Kap')],':')" />
                            <xsl:for-each select=".">
                              <xsl:call-template name="Curr_Type_Only" />
                            </xsl:for-each>
                          </td>
                        </tr>
                      </xsl:if>
                      <xsl:if test="//n1:Invoice/cbc:Note[contains(.,'Net Yekün')]">
                        <tr>
                          <th>Net Yekün</th>
                          <td>
                            <xsl:value-of select="substring-after(//n1:Invoice/cbc:Note[contains(.,'Net Yekün')],':')" />
                            <xsl:for-each select=".">
                              <xsl:call-template name="Curr_Type_Only" />
                            </xsl:for-each>
                          </td>
                        </tr>
                      </xsl:if>
                    </table>
                  </td>
                </tr>
              </table>
            </td>
          </tr>
          <tr>
            <td>
              <xsl:if test="//n1:Invoice/cac:BillingReference/cac:InvoiceDocumentReference/cbc:DocumentTypeCode[text()='İADE' or text()='IADE']">
                <table id="lineTable" width="800">
                  <thead>
                    <tr>
                      <td align="left">
                        <span style="font-weight:bold; " align="center">     İadeye Konu Olan Faturalar</span>
                      </td>
                    </tr>
                  </thead>
                  <tbody>
                    <tr align="left" class="lineTableTr">
                      <td class="lineTableTd">
                        <span style="font-weight:bold; " align="center">     Fatura No</span>
                      </td>
                      <td class="lineTableTd">
                        <span style="font-weight:bold; " align="center">     Tarih</span>
                      </td>
                    </tr>
                    <xsl:for-each select="//n1:Invoice/cac:BillingReference/cac:InvoiceDocumentReference/cbc:DocumentTypeCode[text()='İADE' or text()='IADE']">
                      <tr align="left" class="lineTableTr">
                        <td class="lineTableTd">     
													<xsl:value-of select="../cbc:ID" /></td>
                        <td class="lineTableTd">     
													<xsl:for-each select="../cbc:IssueDate"><xsl:apply-templates select="." /></xsl:for-each></td>
                      </tr>
                    </xsl:for-each>
                  </tbody>
                </table>
              </xsl:if>
            </td>
          </tr>
          <tr>
            <td>
              <xsl:if test="//n1:Invoice/cac:BillingReference/cac:AdditionalDocumentReference/cbc:DocumentTypeCode='OKCBF'">
                <table border="1" id="lineTable" width="800">
                  <thead>
                    <tr>
                      <th colspan="6">ÖKC Bilgileri</th>
                    </tr>
                  </thead>
                  <tbody>
                    <tr id="okcbfHeadTr" style="font-weight:bold;">
                      <td style="width:20%">
                        <xsl:text>Fiş Numarası</xsl:text>
                      </td>
                      <td style="width:10%" align="center">
                        <xsl:text>Fiş Tarihi</xsl:text>
                      </td>
                      <td style="width:10%" align="center">
                        <xsl:text>Fiş Saati</xsl:text>
                      </td>
                      <td style="width:40%" align="center">
                        <xsl:text>Fiş Tipi</xsl:text>
                      </td>
                      <td style="width:10%" align="center">
                        <xsl:text>Z Rapor No</xsl:text>
                      </td>
                      <td style="width:10%" align="center">
                        <xsl:text>ÖKC Seri No</xsl:text>
                      </td>
                    </tr>
                  </tbody>
                  <xsl:for-each select="//n1:Invoice/cac:BillingReference/cac:AdditionalDocumentReference/cbc:DocumentTypeCode[text()='OKCBF']">
                    <tr>
                      <td style="width:20%">
                        <xsl:value-of select="../cbc:ID" />
                      </td>
                      <td style="width:10%" align="center">
                        <xsl:value-of select="../cbc:IssueDate" />
                      </td>
                      <td style="width:10%" align="center">
                        <xsl:value-of select="substring(../cac:ValidityPeriod/cbc:StartTime,1,5)" />
                      </td>
                      <td style="width:40%" align="center">
                        <xsl:choose>
                          <xsl:when test="../cbc:DocumentDescription='AVANS'">
                            <xsl:text>Ön Tahsilat(Avans) Bilgi Fişi</xsl:text>
                          </xsl:when>
                          <xsl:when test="../cbc:DocumentDescription='YEMEK_FIS'">
                            <xsl:text>Yemek Fişi/Kartı ile Yapılan Tahsilat Bilgi Fişi</xsl:text>
                          </xsl:when>
                          <xsl:when test="../cbc:DocumentDescription='E-FATURA'">
                            <xsl:text>E-Fatura Bilgi Fişi</xsl:text>
                          </xsl:when>
                          <xsl:when test="../cbc:DocumentDescription='E-FATURA_IRSALIYE'">
                            <xsl:text>İrsaliye Yerine Geçen E-Fatura Bilgi Fişi</xsl:text>
                          </xsl:when>
                          <xsl:when test="../cbc:DocumentDescription='E-ARSIV'">
                            <xsl:text>E-Arşiv Bilgi Fişi</xsl:text>
                          </xsl:when>
                          <xsl:when test="../cbc:DocumentDescription='E-ARSIV_IRSALIYE'">
                            <xsl:text>İrsaliye Yerine Geçen E-Arşiv Bilgi Fişi</xsl:text>
                          </xsl:when>
                          <xsl:when test="../cbc:DocumentDescription='FATURA'">
                            <xsl:text>Faturalı Satış Bilgi Fişi</xsl:text>
                          </xsl:when>
                          <xsl:when test="../cbc:DocumentDescription='OTOPARK'">
                            <xsl:text>Otopark Giriş Bilgi Fişi</xsl:text>
                          </xsl:when>
                          <xsl:when test="../cbc:DocumentDescription='FATURA_TAHSILAT'">
                            <xsl:text>Fatura Tahsilat Bilgi Fişi</xsl:text>
                          </xsl:when>
                          <xsl:when test="../cbc:DocumentDescription='FATURA_TAHSILAT_KOMISYONLU'">
                            <xsl:text>Komisyonlu Fatura Tahsilat Bilgi Fişi</xsl:text>
                          </xsl:when>
                          <xsl:otherwise>
                            <xsl:text>
                            </xsl:text>
                          </xsl:otherwise>
                        </xsl:choose>
                      </td>
                      <td style="width:10%" align="center">
                        <xsl:value-of select="../cac:Attachment/cac:ExternalReference/cbc:URI" />
                      </td>
                      <td style="width:10%" align="center">
                        <xsl:value-of select="../cac:IssuerParty/cbc:EndpointID" />
                      </td>
                    </tr>
                  </xsl:for-each>
                </table>
                <br />
              </xsl:if>
            </td>
          </tr>
          <tr class="containerTr">
            <td width="900">
              <table id="notesTable">
                <tr align="left">
                  <td id="notesTableTd">
                    <xsl:for-each select="$footerNote">
                      <xsl:if test="contains(.,'Rehinler')">
                        <xsl:if test="//n1:Invoice/cbc:Note[contains(.,'Rehin Dahil Toplam Tutar')]">
                          <tr>
                            <td>
                              <pre align="left">
													Fatura No: 
													<xsl:value-of select="//n1:Invoice/cbc:ID" /></pre>
                            </td>
                          </tr>
                        </xsl:if>
                      </xsl:if>
                      <br />
                      <xsl:if test="not(contains(.,'Komisyoncudur')) and &#xD;&#xA;											  not(contains(.,'Referans No')) and &#xD;&#xA;											  not(contains(.,'Banka')) and &#xD;&#xA;											  not(contains(.,'Net Yekün')) and &#xD;&#xA;											  not(contains(.,'İadeli Kap')) and&#xD;&#xA;											  not(contains(.,'Toplam Kap    :')) and &#xD;&#xA;											  not(contains(.,'Toplam Dara   :')) and 											  &#xD;&#xA;											  not(contains(.,'Toplam Darali :')) and &#xD;&#xA;											  not(contains(.,'Toplam Miktar :')) and&#xD;&#xA;											  not(contains(.,'Marka :')) and&#xD;&#xA;											  not(contains(.,'Stok Giriş Tarihi'))">
                        <pre align="left">
                          <xsl:value-of select="." />
                        </pre>
                      </xsl:if>
                    </xsl:for-each>
                  </td>
                </tr>
                <xsl:if test="//n1:Invoice/cac:PaymentMeans/cac:PayeeFinancialAccount/cbc:PaymentNote">
                  <tr>
                    <td class="noteLbl">
										Ödeme Açıklaması: 
										<xsl:value-of select="//n1:Invoice/cac:PaymentMeans/cac:PayeeFinancialAccount/cbc:PaymentNote" /><br /><xsl:text>IBAN: </xsl:text><xsl:value-of select="//n1:Invoice/cac:PaymentMeans/cac:PayeeFinancialAccount/cbc:ID" /></td>
                  </tr>
                </xsl:if>
                <xsl:for-each select="//n1:Invoice/cac:TaxTotal/cac:TaxSubtotal">
                  <xsl:if test="cbc:Percent=0 and cac:TaxCategory/cac:TaxScheme/cbc:TaxTypeCode='0015'">
                    <b>Vergi İstisna Muafiyet Sebebi: </b>
                    <xsl:value-of select="cac:TaxCategory/cbc:TaxExemptionReason" />
                    <br />
                  </xsl:if>
                </xsl:for-each>
                <xsl:if test="//n1:Invoice/cbc:Note[contains(.,'FOOTER2')]">
                  <tr>
                    <td class="noteLbl">Yazı İle</td>
                    <td>:</td>
                    <td class="capital">
                      <span>
                        <xsl:value-of select="substring(//n1:Invoice/cbc:Note[contains(.,'FOOTER2')],10,1000)" />
                      </span>
                    </td>
                  </tr>
                </xsl:if>
                <xsl:if test="//n1:Invoice/cbc:Note[contains(.,'PLAKA')]">
                  <tr>
                    <td class="noteLbl">Plaka</td>
                    <td>:</td>
                    <td class="capital">
                      <span>
                        <xsl:value-of select="substring-after(//n1:Invoice/cbc:Note[contains(.,'PLAKA')],']')" />
                      </span>
                    </td>
                  </tr>
                </xsl:if>
                <xsl:if test="//n1:Invoice/cac:PaymentTerms/cbc:Note">
                  <tr>
                    <td class="noteLbl">Ödeme Koşulu</td>
                    <td>:</td>
                    <td class="capital">
                      <xsl:value-of select="//n1:Invoice/cac:PaymentTerms/cbc:Note" />
                    </td>
                  </tr>
                </xsl:if>
                <xsl:if test="//n1:Invoice/cac:PaymentMeans/cbc:PaymentDueDate">
                  <tr>
                    <td>
                      <b> Ödeme Tarihi: </b>
                      <xsl:value-of select="//n1:Invoice/cac:PaymentMeans/cbc:PaymentDueDate" />
                    </td>
                  </tr>
                </xsl:if>
                <xsl:if test="//n1:Invoice/cac:PaymentMeans/cac:PayeeFinancialAccount/cbc:PaymentNote">
                  <tr>
                    <td>
                      <b> Hesap Açıklaması: </b>
                      <xsl:value-of select="//n1:Invoice/cac:PaymentMeans/cac:PayeeFinancialAccount/cbc:PaymentNote" />
                    </td>
                  </tr>
                </xsl:if>
                <xsl:if test="//n1:Invoice/cac:PaymentTerms/cbc:Note">
                  <tr>
                    <td>
                      <b> Ödeme Koşulu: </b>
                      <xsl:value-of select="//n1:Invoice/cac:PaymentTerms/cbc:Note" />
                    </td>
                  </tr>
                </xsl:if>
                <xsl:if test="//n1:Invoice/cac:BuyerCustomerParty/cac:Party/cac:PartyIdentification/cbc:ID[@schemeID='PARTYTYPE']='TAXFREE' and //n1:Invoice/cac:TaxRepresentativeParty/cac:PartyTaxScheme/cbc:ExemptionReasonCode">
                  <tr>
                    <td>
                      <b>      VAT OFF - NO CASH REFUND </b>
                    </td>
                  </tr>
                </xsl:if>
                <xsl:if test="//n1:Invoice/cac:Delivery/cac:CarrierParty/cac:PartyName/cbc:Name">
                  <tr>
                    <td>
                      <b> Gönderiyi Taşıyan Unvan : </b>
                      <xsl:value-of select="//n1:Invoice/cac:Delivery/cac:CarrierParty/cac:PartyName/cbc:Name" />
                    </td>
                  </tr>
                </xsl:if>
                <xsl:if test="//n1:Invoice/cac:Delivery/cac:CarrierParty/cac:PartyIdentification/cbc:ID">
                  <tr>
                    <td>
                      <b> Gönderiyi Taşıyan VKN/TCKN : </b>
                      <xsl:value-of select="//n1:Invoice/cac:Delivery/cac:CarrierParty/cac:PartyIdentification/cbc:ID" />
                    </td>
                  </tr>
                </xsl:if>
                <xsl:if test="//n1:Invoice/cac:Delivery/cac:Despatch/cbc:ActualDespatchDate">
                  <tr>
                    <td>
                      <b> Gönderim Tarihi : </b>
                      <xsl:value-of select="//n1:Invoice/cac:Delivery/cac:Despatch/cbc:ActualDespatchDate" />
                    </td>
                  </tr>
                </xsl:if>
                <xsl:if test="//n1:Invoice/cac:AdditionalDocumentReference/cbc:DocumentType = 'ELEKTRONIK' ">
                  <tr>
                    <td>
                      <span style="font-weight:bold;color:blue; ">
                        <xsl:text>e-Arşiv izni kapsamında elektronik ortamda iletilmiştir.</xsl:text>
                      </span>
                    </td>
                  </tr>
                </xsl:if>
                <xsl:if test="//n1:Invoice/cac:Delivery  and //n1:Invoice/cbc:ProfileID!='IHRACAT'">
                  <tr>
                    <td>
                      <span style="font-weight:bold;color:blue; ">
                        <xsl:text>Bu satış internet üzerinden yapılmıştır.</xsl:text>
                      </span>
                    </td>
                  </tr>
                </xsl:if>
                <!--<xsl:if test="//n1:Invoice/cbc:InvoiceTypeCode!='KOMISYONCU'">-->
                <tr>
                  <td>
                    <table id="hesapBilgileri" style="padding:10px 0px; width:890px; margin-top:5px">
                      <tr>
                        <td style="width:100%; padding:0px">
                          <table style="width:100%;float:left;border-collapse: collapse;">
                            <tr>
                              <th colspan="4">
                                <b>BANKA HESAP BİLGİLERİMİZ</b>
                              </th>
                            </tr>
                            <tr>
                              <xsl:if test="//n1:Invoice/cac:PaymentMeans/cac:PayeeFinancialAccount/cbc:ID">
                                <td>IBAN</td>
                                <td class="noteLbl">
                                  <xsl:value-of select="//n1:Invoice/cac:PaymentMeans/cac:PayeeFinancialAccount/cbc:ID" />
                                </td>
                              </xsl:if>
                              <td>Banka Adı</td>
                              <td>IBAN</td>
                            </tr>
                            <xsl:for-each select="//n1:Invoice/cbc:Note[contains(.,'Banka:')]">
                              <xsl:variable name="pBankaBilgisi" select="." />
                              <tr>
                                <td>
                                  <span style="font-weight:bold; ">
                                    <xsl:value-of select="substring-after(substring-before($pBankaBilgisi[contains(.,'Banka:')],'IBAN'), 'Banka:')" />
                                  </span>
                                </td>
                                <td>
                                  <span style="font-weight:bold; ">
                                    <xsl:value-of select="substring-after($pBankaBilgisi[contains(.,'Banka:')],'IBAN')" />
                                  </span>
                                </td>
                              </tr>
                            </xsl:for-each>
                          </table>
                        </td>
                      </tr>
                      <tr height="4">
                        <td>
                        </td>
                      </tr>
                    </table>
                  </td>
                </tr>
                <!--</xsl:if>-->
              </table>
              <xsl:if test="count(//n1:Invoice/cac:DespatchDocumentReference)=0">
                <span style="font-weight:bold;color:blue; ">
                  <xsl:text>İrsaliye yerine geçer.</xsl:text>
                </span>
              </xsl:if>
              <br />
              <xsl:if test="//n1:Invoice/cbc:InvoiceTypeCode!='KOMISYONCU'">
                <span style="font-weight:bold;color:blue; ">
                  <xsl:text>Müşteri beyanına göre düzenlenmiştir .</xsl:text>
                </span>
                <br />
              </xsl:if>
              <xsl:if test="//n1:Invoice/cbc:Note[contains(.,'Komisyoncudur')]">
                <span style="font-weight:bold;color:blue; ">
                  <xsl:text>Komisyoncu sıfatıyla satılmıstır.</xsl:text>
                </span>
              </xsl:if>
              <br />
            </td>
          </tr>
        </table>
        <xsl:if test="//n1:Invoice/cac:AdditionalDocumentReference/cbc:DocumentType = 'INTERNET' and  //n1:Invoice/cac:AdditionalDocumentReference/cbc:DocumentTypeCode = 'EArchiveType'">
          <br />
          <br />
          <br />
          <br />
          <br />
          <table border="1" align="left" id="lineTable" width="800">
            <tbody>
              <tr align="left">
                <td>
                  <b>
                    <xsl:text>İade Bölümü</xsl:text>
                  </b>
                </td>
              </tr>
              <tr align="left" id="lineTableTr">
                <td id="lineTableTd" style="width:20%" align="center">
                  <span style="font-weight:bold; ">
                    <xsl:text>Malzeme/Hizmet Açıklaması</xsl:text>
                  </span>
                </td>
                <td id="lineTableTd" style="width:7.4%" align="center">
                  <span style="font-weight:bold;">
                    <xsl:text>Miktar</xsl:text>
                  </span>
                </td>
                <td id="lineTableTd" style="width:9%" align="center">
                  <span style="font-weight:bold; ">
                    <xsl:text>Birim Fiyat</xsl:text>
                  </span>
                </td>
                <td id="lineTableTd" style="width:7%" align="center">
                  <span style="font-weight:bold; ">
                    <xsl:text>KDV Oranı</xsl:text>
                  </span>
                </td>
                <td id="lineTableTd" style="width:10%" align="center">
                  <span style="font-weight:bold; ">
                    <xsl:text>KDV Tutarı</xsl:text>
                  </span>
                </td>
                <td id="lineTableTd" style="width:10.6%" align="center">
                  <span style="font-weight:bold; ">
                    <xsl:text>Mal Hizmet Tutarı</xsl:text>
                  </span>
                </td>
              </tr>
              <tr align="left">
                <td>
                  <br />
                </td>
                <br />
                <td>
                  <br />
                </td>
                <br />
                <td />
                <br />
                <td />
                <br />
                <td />
                <td>
                  <br />
                </td>
              </tr>
              <tr align="left">
                <td>
                  <br />
                </td>
                <br />
                <td>
                  <br />
                </td>
                <br />
                <td />
                <br />
                <td />
                <br />
                <td />
                <td>
                  <br />
                </td>
              </tr>
              <tr align="left">
                <td>
                  <br />
                </td>
                <br />
                <td>
                  <br />
                </td>
                <br />
                <td />
                <br />
                <td />
                <br />
                <td />
                <td>
                  <br />
                </td>
              </tr>
            </tbody>
          </table>
          <br />
          <br />
          <br />
          <br />
          <br />
          <br />
          <br />
          <b>
            <xsl:text>Firma/Şahıs Unvanı :</xsl:text>
          </b>
          <br />
          <b>
            <xsl:text>Vkn/Tckno :</xsl:text>
          </b>
          <br />
          <b>
            <xsl:text>İmza Kaşe</xsl:text>
          </b>
          <br />
        </xsl:if>
      </body>
    </html>
  </xsl:template>
  <xsl:template name="dovizi_oku">
    <xsl:param name="doviz" />
    <xsl:variable name="okunacak" select="." />
    <xsl:variable name="noktadan_sonra" select="round(($okunacak - floor($okunacak)) * 100)" />
    <xsl:call-template name="sayi_oku">
      <xsl:with-param name="okunacak" select="." />
    </xsl:call-template>
    <xsl:if test="$doviz">
      <xsl:choose>
        <xsl:when test="$doviz =  'TRL' or $doviz =  'TRY'">
          <xsl:value-of select="' Türk Lirası'" />
          <xsl:if test="$noktadan_sonra &gt; 0">
            <xsl:value-of select="' '" />
            <xsl:call-template name="sayi_oku">
              <xsl:with-param name="okunacak" select="$noktadan_sonra" />
            </xsl:call-template>
            <xsl:value-of select="' Kuruş'" />
          </xsl:if>
        </xsl:when>
        <xsl:otherwise>
          <xsl:text> </xsl:text>
          <xsl:value-of select="$doviz" />
          <xsl:if test="$noktadan_sonra &gt; 0">
            <xsl:value-of select="' '" />
            <xsl:call-template name="sayi_oku">
              <xsl:with-param name="okunacak" select="$noktadan_sonra" />
            </xsl:call-template>
          </xsl:if>
        </xsl:otherwise>
      </xsl:choose>
    </xsl:if>
  </xsl:template>
  <xsl:template name="sayi_oku">
    <xsl:param name="okunacak" />
    <xsl:variable name="tam_sayi" select="floor($okunacak)" />
    <xsl:variable name="birler" select="floor($okunacak) mod 10" />
    <xsl:variable name="onlar" select="floor(floor($tam_sayi mod 100) div 10)" />
    <xsl:variable name="yuzler" select="floor(floor($tam_sayi mod 1000) div 100)" />
    <xsl:variable name="binler" select="floor(floor($tam_sayi mod 1000000) div 1000)" />
    <xsl:variable name="milyonlar" select="floor(floor($tam_sayi mod 1000000000) div 1000000)" />
    <xsl:variable name="milyarlar" select="floor(floor($tam_sayi mod 1000000000000) div 1000000000)" />
    <xsl:if test="$milyarlar &gt; 0">
      <xsl:call-template name="sayi_oku_3hane">
        <xsl:with-param name="sayi" select="$milyarlar" />
      </xsl:call-template> Milyar
		</xsl:if>
    <xsl:if test="$milyonlar &gt; 0">
      <xsl:call-template name="sayi_oku_3hane">
        <xsl:with-param name="sayi" select="$milyonlar" />
      </xsl:call-template> Milyon
		</xsl:if>
    <xsl:if test="$binler &gt; 0">
      <xsl:if test="$binler = 1">Bin </xsl:if>
      <xsl:if test="$binler &gt; 1">
        <xsl:call-template name="sayi_oku_3hane">
          <xsl:with-param name="sayi" select="$binler" />
        </xsl:call-template> Bin
			</xsl:if>
    </xsl:if>
    <xsl:call-template name="yuzler_oku">
      <xsl:with-param name="sayi" select="$yuzler" />
    </xsl:call-template>
    <xsl:call-template name="onlar_oku">
      <xsl:with-param name="sayi" select="$onlar" />
    </xsl:call-template>
    <xsl:call-template name="birler_oku">
      <xsl:with-param name="sayi" select="$birler" />
    </xsl:call-template>
  </xsl:template>
  <xsl:template name="sayi_oku_3hane">
    <xsl:param name="sayi" />
    <xsl:variable name="tam_sayi" select="floor($sayi)" />
    <xsl:variable name="birler" select="floor($sayi) mod 10" />
    <xsl:variable name="onlar" select="floor(floor($tam_sayi mod 100) div 10)" />
    <xsl:variable name="yuzler" select="floor(floor($tam_sayi mod 1000) div 100)" />
    <xsl:call-template name="yuzler_oku">
      <xsl:with-param name="sayi" select="$yuzler" />
    </xsl:call-template>
    <xsl:call-template name="onlar_oku">
      <xsl:with-param name="sayi" select="$onlar" />
    </xsl:call-template>
    <xsl:call-template name="birler_oku">
      <xsl:with-param name="sayi" select="$birler" />
    </xsl:call-template>
  </xsl:template>
  <xsl:template name="birler_oku">
    <xsl:param name="sayi" />
    <xsl:choose>
      <xsl:when test="$sayi =  1">Bir </xsl:when>
      <xsl:when test="$sayi =  2">İki </xsl:when>
      <xsl:when test="$sayi =  3">Üç </xsl:when>
      <xsl:when test="$sayi =  4">Dört </xsl:when>
      <xsl:when test="$sayi =  5">Beş </xsl:when>
      <xsl:when test="$sayi =  6">Altı </xsl:when>
      <xsl:when test="$sayi =  7">Yedi </xsl:when>
      <xsl:when test="$sayi =  8">Sekiz </xsl:when>
      <xsl:when test="$sayi =  9">Dokuz </xsl:when>
      <xsl:otherwise>
      </xsl:otherwise>
    </xsl:choose>
  </xsl:template>
  <xsl:template name="onlar_oku">
    <xsl:param name="sayi" />
    <xsl:choose>
      <xsl:when test="$sayi =  1">On </xsl:when>
      <xsl:when test="$sayi =  2">Yirmi </xsl:when>
      <xsl:when test="$sayi =  3">Otuz </xsl:when>
      <xsl:when test="$sayi =  4">Kırk </xsl:when>
      <xsl:when test="$sayi =  5">Elli </xsl:when>
      <xsl:when test="$sayi =  6">Altmış </xsl:when>
      <xsl:when test="$sayi =  7">Yetmiş </xsl:when>
      <xsl:when test="$sayi =  8">Seksen </xsl:when>
      <xsl:when test="$sayi =  9">Doksan </xsl:when>
      <xsl:otherwise />
    </xsl:choose>
  </xsl:template>
  <xsl:template name="yuzler_oku">
    <xsl:param name="sayi" />
    <xsl:choose>
      <xsl:when test="$sayi =  1">Yüz </xsl:when>
      <xsl:when test="$sayi =  2">İki Yüz </xsl:when>
      <xsl:when test="$sayi =  3">Üç Yüz </xsl:when>
      <xsl:when test="$sayi =  4">Dört Yüz </xsl:when>
      <xsl:when test="$sayi =  5">Beş Yüz </xsl:when>
      <xsl:when test="$sayi =  6">Altı Yüz </xsl:when>
      <xsl:when test="$sayi =  7">Yedi Yüz </xsl:when>
      <xsl:when test="$sayi =  8">Sekiz Yüz </xsl:when>
      <xsl:when test="$sayi =  9">Dokuz Yüz </xsl:when>
      <xsl:otherwise />
    </xsl:choose>
  </xsl:template>
  <xsl:template name="binler_oku">
    <xsl:param name="sayi" />
    <xsl:choose>
      <xsl:when test="$sayi =  1">Bin </xsl:when>
      <xsl:when test="$sayi =  2">İki Bin </xsl:when>
      <xsl:when test="$sayi =  3">Üç Bin </xsl:when>
      <xsl:when test="$sayi =  4">Dört Bin </xsl:when>
      <xsl:when test="$sayi =  5">Beş Bin </xsl:when>
      <xsl:when test="$sayi =  6">Altı Bin </xsl:when>
      <xsl:when test="$sayi =  7">Yedi Bin </xsl:when>
      <xsl:when test="$sayi =  8">Sekiz Bin </xsl:when>
      <xsl:when test="$sayi =  9">Dokuz Bin </xsl:when>
      <xsl:otherwise />
    </xsl:choose>
  </xsl:template>
  <xsl:template name="onbinler_oku">
    <xsl:param name="sayi" />
    <xsl:if test="$sayi &gt; 0">
      <xsl:call-template name="onlar_oku">
        <xsl:with-param name="sayi" select="$sayi" />
      </xsl:call-template>Bin
		</xsl:if>
  </xsl:template>
  <xsl:template name="parcala">
    <xsl:param name="csv" />
    <xsl:param name="isaret" />
    <xsl:variable name="first-item" select="normalize-space(substring-before( concat( $csv, '|'), '|'))" />
    <xsl:if test="$csv">
      <xsl:if test="normalize-space(substring-after(concat($first-item, ''), $isaret))">
        <xsl:value-of disable-output-escaping="yes" select="normalize-space(substring-after(concat($first-item, ''), $isaret))" />
      </xsl:if>
      <xsl:call-template name="parcala">
        <xsl:with-param name="csv" select="substring-after($csv,'|')" />
        <xsl:with-param name="isaret" select="$isaret" />
      </xsl:call-template>
    </xsl:if>
  </xsl:template>
  <xsl:template match="dateFormatter">
    <xsl:value-of select="substring(.,9,2)" />-<xsl:value-of select="substring(.,6,2)" />-<xsl:value-of select="substring(.,1,4)" /></xsl:template>
  <xsl:template match="//n1:Invoice/cac:InvoiceLine">
    <tr id="lineTableTr">
      <td id="lineTableTd">
        <span>
          <xsl:text> </xsl:text>
          <xsl:value-of select="./cbc:ID" />
        </span>
      </td>
      <xsl:if test="//n1:Invoice/cac:InvoiceLine/cac:Item/cac:SellersItemIdentification">
        <td id="lineTableTd">
          <span>
            <xsl:text> </xsl:text>
            <xsl:value-of select="./cac:Item/cac:SellersItemIdentification/cbc:ID" />
          </span>
        </td>
      </xsl:if>
      <td id="lineTableTd">
        <span>
          <xsl:text> </xsl:text>
          <xsl:value-of select="./cac:Item/cbc:Name" />
        </span>
      </td>
      <td id="lineTableTd" align="right">
        <span>
          <xsl:text> </xsl:text>
          <xsl:value-of select="format-number(./cbc:InvoicedQuantity, '###.##0,####', 'european')" />
          <xsl:if test="./cbc:InvoicedQuantity/@unitCode">
            <xsl:for-each select="./cbc:InvoicedQuantity">
              <xsl:text>
              </xsl:text>
              <xsl:choose>
                <xsl:when test="@unitCode  = '26'">
                  <span>
                    <xsl:text>Ton</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'TNE'">
                  <span>
                    <xsl:text>Ton</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'BX'">
                  <span>
                    <xsl:text>Kutu</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'LTR'">
                  <span>
                    <xsl:text>LT</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'C62'">
                  <span>
                    <xsl:text>Adet</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'KGM'">
                  <span>
                    <xsl:text>KG</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'BE'">
                  <span>
                    <xsl:text>Bağ</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'KJO'">
                  <span>
                    <xsl:text>kJ</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'GRM'">
                  <span>
                    <xsl:text>G</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'MGM'">
                  <span>
                    <xsl:text>MG</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'NT'">
                  <span>
                    <xsl:text>Net Ton</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'GT'">
                  <span>
                    <xsl:text>GT</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'MTR'">
                  <span>
                    <xsl:text>M</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'MMT'">
                  <span>
                    <xsl:text>MM</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'KTM'">
                  <span>
                    <xsl:text>KM</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'MLT'">
                  <span>
                    <xsl:text>ML</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'MMQ'">
                  <span>
                    <xsl:text>MM3</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'CLT'">
                  <span>
                    <xsl:text>CL</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'CMK'">
                  <span>
                    <xsl:text>CM2</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'CMQ'">
                  <span>
                    <xsl:text>CM3</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'CMT'">
                  <span>
                    <xsl:text>CM</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'MTK'">
                  <span>
                    <xsl:text>M2</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'MTQ'">
                  <span>
                    <xsl:text>M3</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'DAY'">
                  <span>
                    <xsl:text>Gün</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'MON'">
                  <span>
                    <xsl:text>Ay</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'ANN'">
                  <span>
                    <xsl:text>Yıl</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'HUR'">
                  <span>
                    <xsl:text>Saat</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'D61'">
                  <span>
                    <xsl:text>Dakika</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'D62'">
                  <span>
                    <xsl:text>Saniye</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'PA'">
                  <span>
                    <xsl:text>Paket</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'R9'">
                  <span>
                    <xsl:text>1000 m3</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'KWH'">
                  <span>
                    <xsl:text>KWH</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'GMS'">
                  <span>
                    <xsl:text>Gümüs</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'CTM'">
                  <span>
                    <xsl:text>Karat</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'ANN'">
                  <span>
                    <xsl:text>Yıl</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'HUR'">
                  <span>
                    <xsl:text>Saat</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'MIN'">
                  <span>
                    <xsl:text>Dakika</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'SEC'">
                  <span>
                    <xsl:text>Saniye</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'LPA'">
                  <span>
                    <xsl:text>saf alkol lt</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'BG'">
                  <span>
                    <xsl:text>Torba</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'PR'">
                  <span>
                    <xsl:text>Adet-Çift</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'DZN'">
                  <span>
                    <xsl:text>Düzine</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'SET'">
                  <span>
                    <xsl:text>Set</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'NPL'">
                  <span>
                    <xsl:text>Koli</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'FTK'">
                  <span>
                    <xsl:text>Ayak kare</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'FOT'">
                  <span>
                    <xsl:text>Ayak</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'AFF'">
                  <span>
                    <xsl:text>AFİF birim fiyatı</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'AKQ'">
                  <span>
                    <xsl:text>ATV Birim Fiyatı</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'AYR'">
                  <span>
                    <xsl:text>Altın ayarı</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'B32'">
                  <span>
                    <xsl:text>KG-METRE kare</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'BAS'">
                  <span>
                    <xsl:text>Bas</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'CCT'">
                  <span>
                    <xsl:text>Ton başı taşıma</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'D30'">
                  <span>
                    <xsl:text>Brüt Kalori değeri</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'D40'">
                  <span>
                    <xsl:text>Bin Litre</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'CEN'">
                  <span>
                    <xsl:text>Yüz adet</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'T3'">
                  <span>
                    <xsl:text>Bin adet</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'OTB'">
                  <span>
                    <xsl:text>OTV birim fiyatı</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'OMV'">
                  <span>
                    <xsl:text>OTV Maktu Vergi</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'D97'">
                  <span>
                    <xsl:text>Palet</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'MLT'">
                  <span>
                    <xsl:text>Mililitre</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'MGM'">
                  <span>
                    <xsl:text>Miligram</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'GRM'">
                  <span>
                    <xsl:text>Gram</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'KGM'">
                  <span>
                    <xsl:text>Kilogram</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'GFI'">
                  <span>
                    <xsl:text>Fıssıle İzotop Gramı</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'KUR'">
                  <span>
                    <xsl:text>Uranyum Kilogramı</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'KSH'">
                  <span>
                    <xsl:text>Sodyum Hidroksit Kilogramı</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'KSD'">
                  <span>
                    <xsl:text>%90 Kuru Ürün Kilogramı</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'KPR'">
                  <span>
                    <xsl:text>Kilogram-Çift</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'KPH'">
                  <span>
                    <xsl:text>Kg Potasyum Oksid</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'KFO'">
                  <span>
                    <xsl:text>Difosfor Pentaoksit Kilogramı</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'K62'">
                  <span>
                    <xsl:text>Kilogram-Adet</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'K58'">
                  <span>
                    <xsl:text>Kurutulmuş Net Ağırlıklı Kilogramı</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'K20'">
                  <span>
                    <xsl:text>Kilogram Potasyum Oksit</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'LO'">
                  <span>
                    <xsl:text>Lot</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'KMA'">
                  <span>
                    <xsl:text>METİL AMİNLERİN KİLOGRAMI</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'KNI'">
                  <span>
                    <xsl:text>AZOTUN KİLOGRAMI</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'D32'">
                  <span>
                    <xsl:text>TERAWATT SAAT</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'GWH'">
                  <span>
                    <xsl:text>MEGAWATT SAAT </xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'KWT'">
                  <span>
                    <xsl:text>KİLOWATT </xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'DMK'">
                  <span>
                    <xsl:text>DESİMETRE KARE</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'SM3'">
                  <span>
                    <xsl:text>STANDART METREKÜP</xsl:text>
                  </span>
                </xsl:when>
              </xsl:choose>
            </xsl:for-each>
          </xsl:if>
        </span>
      </td>
      <td id="lineTableTd" align="right">
        <span>
          <xsl:text> </xsl:text>
          <xsl:value-of select="format-number(./cac:Price/cbc:PriceAmount, '###.##0,########', 'european')" />
          <xsl:if test="./cac:Price/cbc:PriceAmount/@currencyID">
            <xsl:text>
            </xsl:text>
            <xsl:if test="./cac:Price/cbc:PriceAmount/@currencyID = &quot;TRL&quot; or ./cac:Price/cbc:PriceAmount/@currencyID = &quot;TRY&quot;">
              <xsl:text>TRY</xsl:text>
            </xsl:if>
            <xsl:if test="./cac:Price/cbc:PriceAmount/@currencyID != &quot;TRL&quot; and ./cac:Price/cbc:PriceAmount/@currencyID != &quot;TRY&quot;">
              <xsl:value-of select="./cac:Price/cbc:PriceAmount/@currencyID" />
            </xsl:if>
          </xsl:if>
        </span>
      </td>
      <xsl:if test="//n1:Invoice/cac:InvoiceLine/cac:AllowanceCharge/cbc:MultiplierFactorNumeric &gt;0">
        <xsl:if test="$iskontoCount &gt; 2">
          <td id="lineTableTd" align="right" width="75">
            <xsl:text> </xsl:text>
            <xsl:for-each select="./cac:AllowanceCharge/cbc:MultiplierFactorNumeric">
              <xsl:variable name="position" select="position()" />
              <xsl:value-of select="format-number(. * 100, '###.##0,00', 'european')" />
              <xsl:if test="$iskontoCount &gt; $position">
                <xsl:text> +</xsl:text>
              </xsl:if>
            </xsl:for-each>
          </td>
        </xsl:if>
        <xsl:if test="$iskontoCount &lt; 2">
          <td id="lineTableTd" align="right">
            <xsl:text> </xsl:text>
            <xsl:for-each select="./cac:AllowanceCharge/cbc:MultiplierFactorNumeric">
              <xsl:variable name="position" select="position()" />
              <xsl:value-of select="format-number(. * 100, '###.##0,00', 'european')" />
              <xsl:if test="$iskontoCount &gt; $position">
                <xsl:text> +</xsl:text>
              </xsl:if>
            </xsl:for-each>
          </td>
        </xsl:if>
        <xsl:if test="$iskontoCount = 2">
          <td id="lineTableTd" align="right" width="100">
            <xsl:text> </xsl:text>
            <xsl:for-each select="./cac:AllowanceCharge/cbc:MultiplierFactorNumeric">
              <xsl:variable name="position" select="position()" />
              <xsl:value-of select="format-number(. * 100, '###.##0,00', 'european')" />
              <xsl:if test="$iskontoCount &gt; $position">
                <xsl:text> +</xsl:text>
              </xsl:if>
            </xsl:for-each>
          </td>
        </xsl:if>
      </xsl:if>
      <xsl:if test="//n1:Invoice/cac:InvoiceLine/cac:AllowanceCharge/cbc:Amount &gt;0">
        <td align="right">
          <xsl:for-each select="./cac:AllowanceCharge">
            <xsl:if test=".">
              <xsl:value-of select="format-number(./cbc:Amount, '###.##0,00', 'european')" />
            </xsl:if>
            <xsl:if test="./cbc:Amount/@currencyID">
              <xsl:if test="./cbc:Amount/@currencyID = 'TRY'">
                <xsl:text> TRY</xsl:text>
              </xsl:if>
              <xsl:if test="./cbc:Amount/@currencyID != 'TRY'">
                <xsl:value-of select="./cbc:Amount/@currencyID" />
              </xsl:if>
            </xsl:if>
            <xsl:variable name="position" select="position()" />
            <xsl:if test="$iskontoCount &gt; $position">
              <xsl:text> +</xsl:text>
            </xsl:if>
          </xsl:for-each>
        </td>
      </xsl:if>
      <td id="lineTableTd" align="right">
        <span>
          <xsl:text> </xsl:text>
          <xsl:for-each select="./cac:TaxTotal/cac:TaxSubtotal/cac:TaxCategory/cac:TaxScheme">
            <xsl:if test="cbc:TaxTypeCode='0015' ">
              <xsl:text>
              </xsl:text>
              <xsl:if test="../../cbc:Percent">
                <xsl:text> %</xsl:text>
                <xsl:value-of select="format-number(../../cbc:Percent, '###.##0,00', 'european')" />
              </xsl:if>
            </xsl:if>
          </xsl:for-each>
        </span>
      </td>
      <td id="lineTableTd" align="right">
        <span>
          <xsl:text> </xsl:text>
          <xsl:for-each select="./cac:TaxTotal/cac:TaxSubtotal/cac:TaxCategory/cac:TaxScheme">
            <xsl:if test="cbc:TaxTypeCode='0015' ">
              <xsl:text>
              </xsl:text>
              <xsl:value-of select="format-number(../../cbc:TaxAmount, '###.##0,00', 'european')" />
              <xsl:if test="../../cbc:TaxAmount/@currencyID">
                <xsl:text>
                </xsl:text>
                <xsl:if test="../../cbc:TaxAmount/@currencyID = 'TRY'">
                  <xsl:text>TRY</xsl:text>
                </xsl:if>
                <xsl:if test="../../cbc:TaxAmount/@currencyID != 'TRY'">
                  <xsl:value-of select="../../cbc:TaxAmount/@currencyID" />
                </xsl:if>
              </xsl:if>
            </xsl:if>
          </xsl:for-each>
        </span>
      </td>
      <xsl:if test="//n1:Invoice/cac:InvoiceLine/cac:WithholdingTaxTotal/cac:TaxSubtotal/cac:TaxCategory/cac:TaxScheme/cbc:TaxTypeCode!='0015' and&#xD;&#xA;						  //n1:Invoice/cbc:InvoiceTypeCode!='KOMISYONCU'">
        <td id="lineTableTd" style="font-size: xx-small" align="right">
          <span>
            <xsl:text> </xsl:text>
            <xsl:for-each select="./cac:TaxTotal/cac:TaxSubtotal/cac:TaxCategory/cac:TaxScheme">
              <xsl:if test="cbc:TaxTypeCode!='0015' ">
                <xsl:text>
                </xsl:text>
                <xsl:value-of select="cbc:Name" />
                <xsl:if test="../../cbc:Percent">
                  <xsl:text> (%</xsl:text>
                  <xsl:value-of select="format-number(../../cbc:Percent, '###.##0,00', 'european')" />
                  <xsl:text>)=</xsl:text>
                </xsl:if>
                <xsl:value-of select="format-number(../../cbc:TaxAmount, '###.##0,00', 'european')" />
                <xsl:if test="../../cbc:TaxAmount/@currencyID">
                  <xsl:text>
                  </xsl:text>
                  <xsl:if test="../../cbc:TaxAmount/@currencyID = 'TRY'">
                    <xsl:text>TRY</xsl:text>
                  </xsl:if>
                  <xsl:if test="../../cbc:TaxAmount/@currencyID != 'TRY'">
                    <xsl:value-of select="../../cbc:TaxAmount/@currencyID" />
                  </xsl:if>
                </xsl:if>
              </xsl:if>
            </xsl:for-each>
            <xsl:for-each select="./cac:WithholdingTaxTotal/cac:TaxSubtotal/cac:TaxCategory/cac:TaxScheme">
              <xsl:text>KDV TEVKİFAT </xsl:text>
              <xsl:if test="../../cbc:Percent">
                <xsl:text> (%</xsl:text>
                <xsl:value-of select="format-number(../../cbc:Percent, '###.##0,00', 'european')" />
                <xsl:text>)=</xsl:text>
              </xsl:if>
              <xsl:value-of select="format-number(../../cbc:TaxAmount, '###.##0,00', 'european')" />
              <xsl:if test="../../cbc:TaxAmount/@currencyID">
                <xsl:text>
                </xsl:text>
                <xsl:if test="../../cbc:TaxAmount/@currencyID = 'TRL' or ../../cbc:TaxAmount/@currencyID = 'TRY'">
                  <xsl:text>TRY</xsl:text>
                  <xsl:text>
</xsl:text>
                </xsl:if>
                <xsl:if test="../../cbc:TaxAmount/@currencyID != 'TRL' and ../../cbc:TaxAmount/@currencyID != 'TRY'">
                  <xsl:value-of select="../../cbc:TaxAmount/@currencyID" />
                  <xsl:text>
</xsl:text>
                </xsl:if>
              </xsl:if>
            </xsl:for-each>
            <xsl:if test="n1:Invoice/cac:WithholdingTaxTotal/cac:TaxSubtotal[starts-with(./cac:TaxCategory/cac:TaxScheme/cbc:TaxTypeCode,'6')]">
              <xsl:for-each select="n1:Invoice/cac:WithholdingTaxTotal/cac:TaxSubtotal[starts-with(./cac:TaxCategory/cac:TaxScheme/cbc:TaxTypeCode,'6')]">
                <tr id="budgetContainerTr" align="right">
                  <td id="lineTableBudgetTd" width="300px" align="right">
                    <span style="font-weight:bold; ">
                      <xsl:text>KDV Tevkifat Tutarı (</xsl:text>
                      <xsl:value-of select="./cac:TaxCategory/cac:TaxScheme/cbc:TaxTypeCode" />)<xsl:text>(%</xsl:text><xsl:value-of select="cbc:Percent" /><xsl:text>)</xsl:text>:											
									</span>
                  </td>
                  <td id="lineTableBudgetTd" style="width:92px; " align="right">
                    <xsl:value-of select="format-number(cbc:TaxAmount, '###.##0,00', 'european')" />
                    <span>
                      <xsl:if test="//n1:Invoice/cbc:DocumentCurrencyCode = 'TRY' or //n1:Invoice/cbc:DocumentCurrencyCode = 'TRL'">
                        <xsl:text> TL</xsl:text>
                      </xsl:if>
                      <xsl:if test="//n1:Invoice/cbc:DocumentCurrencyCode != 'TRY' and //n1:Invoice/cbc:DocumentCurrencyCode != 'TRL'">
                        <xsl:text>
                        </xsl:text>
                        <xsl:value-of select="//n1:Invoice/cbc:DocumentCurrencyCode" />
                      </xsl:if>
                    </span>
                  </td>
                </tr>
              </xsl:for-each>
            </xsl:if>
          </span>
        </td>
      </xsl:if>
      <td id="lineTableTd" align="right">
        <span>
          <xsl:text> </xsl:text>
          <xsl:value-of select="format-number(./cbc:LineExtensionAmount, '###.##0,00', 'european')" />
          <xsl:if test="./cbc:LineExtensionAmount/@currencyID">
            <xsl:text>
            </xsl:text>
            <xsl:if test="./cbc:LineExtensionAmount/@currencyID = 'TRY' ">
              <xsl:text>TRY</xsl:text>
            </xsl:if>
            <xsl:if test="./cbc:LineExtensionAmount/@currencyID != 'TRY' ">
              <xsl:value-of select="./cbc:LineExtensionAmount/@currencyID" />
            </xsl:if>
          </xsl:if>
        </span>
      </td>
      <xsl:if test="//n1:Invoice/cbc:ProfileID='IHRACAT'">
        <td class="lineTableTd" align="right">
          <xsl:text> </xsl:text>
          <xsl:for-each select="cac:Delivery/cac:DeliveryTerms/cbc:ID[@schemeID='INCOTERMS']">
            <xsl:text> </xsl:text>
            <xsl:apply-templates />
          </xsl:for-each>
        </td>
        <td class="lineTableTd" align="right">
          <xsl:text> </xsl:text>
          <xsl:for-each select="cac:Delivery/cac:Shipment/cac:TransportHandlingUnit/cac:ActualPackage/cbc:PackagingTypeCode">
            <xsl:text> </xsl:text>
            <xsl:call-template name="Packaging">
              <xsl:with-param name="PackagingType">
                <xsl:value-of select="." />
              </xsl:with-param>
            </xsl:call-template>
          </xsl:for-each>
        </td>
        <td class="lineTableTd" align="right">
          <xsl:text> </xsl:text>
          <xsl:for-each select="cac:Delivery/cac:Shipment/cac:TransportHandlingUnit/cac:ActualPackage/cbc:ID">
            <xsl:text> </xsl:text>
            <xsl:apply-templates />
          </xsl:for-each>
        </td>
        <td class="lineTableTd" align="right">
          <xsl:text> </xsl:text>
          <xsl:for-each select="cac:Delivery/cac:Shipment/cac:TransportHandlingUnit/cac:ActualPackage/cbc:Quantity">
            <xsl:text> </xsl:text>
            <xsl:apply-templates />
          </xsl:for-each>
        </td>
        <td class="lineTableTd" align="right">
          <xsl:text> </xsl:text>
          <xsl:for-each select="cac:Delivery/cac:DeliveryAddress">
            <xsl:text> </xsl:text>
            <xsl:apply-templates />
          </xsl:for-each>
        </td>
        <td class="lineTableTd" align="right">
          <xsl:text> </xsl:text>
          <xsl:for-each select="cac:Delivery/cac:Shipment/cac:ShipmentStage/cbc:TransportModeCode">
            <xsl:text> </xsl:text>
            <xsl:call-template name="TransportMode">
              <xsl:with-param name="TransportModeType">
                <xsl:value-of select="." />
              </xsl:with-param>
            </xsl:call-template>
          </xsl:for-each>
        </td>
        <td class="lineTableTd" align="right">
          <xsl:text> </xsl:text>
          <xsl:for-each select="cac:Delivery/cac:Shipment/cac:GoodsItem/cbc:RequiredCustomsID">
            <xsl:text> </xsl:text>
            <xsl:apply-templates />
          </xsl:for-each>
        </td>
      </xsl:if>
    </tr>
  </xsl:template>
  <xsl:template match="//n1:Invoice">
    <tr id="lineTableTr">
      <td id="lineTableTd">
        <span>
          <xsl:text> </xsl:text>
        </span>
      </td>
      <xsl:if test="//n1:Invoice/cac:InvoiceLine/cac:Item/cac:SellersItemIdentification">
        <td id="lineTableTd">
          <span>
            <xsl:text> </xsl:text>
          </span>
        </td>
      </xsl:if>
      <td id="lineTableTd">
        <span>
          <xsl:text> </xsl:text>
        </span>
      </td>
      <td id="lineTableTd" align="right">
        <span>
          <xsl:text> </xsl:text>
        </span>
      </td>
      <td id="lineTableTd" align="right">
        <span>
          <xsl:text> </xsl:text>
        </span>
      </td>
      <xsl:if test="//n1:Invoice/cac:InvoiceLine/cac:AllowanceCharge/cbc:MultiplierFactorNumeric &gt;0">
        <td id="lineTableTd" align="right">
          <span>
            <xsl:text> </xsl:text>
          </span>
        </td>
      </xsl:if>
      <xsl:if test="//n1:Invoice/cac:InvoiceLine/cac:AllowanceCharge/cbc:Amount &gt;0">
        <td id="lineTableTd" align="right">
          <span>
            <xsl:text> </xsl:text>
          </span>
        </td>
      </xsl:if>
      <td id="lineTableTd" align="right">
        <span>
          <xsl:text> </xsl:text>
        </span>
      </td>
      <td id="lineTableTd" align="right">
        <span>
          <xsl:text> </xsl:text>
        </span>
      </td>
      <xsl:if test="//n1:Invoice/cac:InvoiceLine/cac:WithholdingTaxTotal/cac:TaxSubtotal/cac:TaxCategory/cac:TaxScheme/cbc:TaxTypeCode!='0015'">
        <td id="lineTableTd" align="right">
          <span>
            <xsl:text> </xsl:text>
          </span>
        </td>
      </xsl:if>
      <td id="lineTableTd" align="right">
        <span>
          <xsl:text> </xsl:text>
        </span>
      </td>
      <xsl:if test="//n1:Invoice/cbc:ProfileID='IHRACAT'">
        <td class="lineTableTd" align="right">
          <xsl:text> </xsl:text>
        </td>
        <td class="lineTableTd" align="right">
          <xsl:text> </xsl:text>
        </td>
        <td class="lineTableTd" align="right">
          <xsl:text> </xsl:text>
        </td>
        <td class="lineTableTd" align="right">
          <xsl:text> </xsl:text>
        </td>
        <td class="lineTableTd" align="right">
          <xsl:text> </xsl:text>
        </td>
        <td class="lineTableTd" align="right">
          <xsl:text> </xsl:text>
        </td>
        <td class="lineTableTd" align="right">
          <xsl:text> </xsl:text>
        </td>
      </xsl:if>
    </tr>
  </xsl:template>
  <xsl:template name="Party_Title">
    <xsl:param name="PartyType" />
    <td style="width:469px; " align="left">
      <xsl:if test="cac:PartyName">
        <xsl:value-of select="cac:PartyName/cbc:Name" />
        <br />
      </xsl:if>
      <xsl:for-each select="cac:Person">
        <xsl:for-each select="cbc:Title">
          <xsl:apply-templates />
          <xsl:text> </xsl:text>
        </xsl:for-each>
        <xsl:for-each select="cbc:FirstName">
          <xsl:apply-templates />
          <xsl:text> </xsl:text>
        </xsl:for-each>
        <xsl:for-each select="cbc:MiddleName">
          <xsl:apply-templates />
          <xsl:text>  </xsl:text>
        </xsl:for-each>
        <xsl:for-each select="cbc:FamilyName">
          <xsl:apply-templates />
          <xsl:text> </xsl:text>
        </xsl:for-each>
        <xsl:for-each select="cbc:NameSuffix">
          <xsl:apply-templates />
        </xsl:for-each>
        <xsl:if test="$PartyType='TAXFREE'">
          <br />
          <xsl:text>Pasaport No: </xsl:text>
          <xsl:value-of select="cac:IdentityDocumentReference/cbc:ID" />
          <br />
          <xsl:text>Ülkesi: </xsl:text>
          <xsl:for-each select="cbc:NationalityID">
            <xsl:call-template name="Country">
              <xsl:with-param name="CountryType">
                <xsl:value-of select="." />
              </xsl:with-param>
            </xsl:call-template>
          </xsl:for-each>
        </xsl:if>
      </xsl:for-each>
    </td>
  </xsl:template>
  <xsl:template name="Party_Adress">
    <xsl:param name="PartyType" />
    <td style="width:469px; " align="left">
      <xsl:for-each select="cac:PostalAddress">
        <xsl:for-each select="cbc:StreetName">
          <xsl:apply-templates />
          <xsl:text> </xsl:text>
        </xsl:for-each>
        <xsl:for-each select="cbc:BuildingName">
          <xsl:apply-templates />
        </xsl:for-each>
        <xsl:for-each select="cbc:BuildingNumber">
          <xsl:text> No:</xsl:text>
          <xsl:apply-templates />
          <xsl:text> </xsl:text>
        </xsl:for-each>
        <br />
        <xsl:for-each select="cbc:Room">
          <xsl:text>Kapı No:</xsl:text>
          <xsl:apply-templates />
          <xsl:text> </xsl:text>
        </xsl:for-each>
        <br />
        <xsl:for-each select="cbc:PostalZone">
          <xsl:apply-templates />
          <xsl:text> </xsl:text>
        </xsl:for-each>
        <xsl:for-each select="cbc:CitySubdivisionName">
          <xsl:apply-templates />
          <xsl:text>/ </xsl:text>
        </xsl:for-each>
        <xsl:for-each select="cbc:CityName">
          <xsl:apply-templates />
          <xsl:text> </xsl:text>
        </xsl:for-each>
        <xsl:if test="$PartyType!='OTHER'">
          <br />
          <xsl:value-of select="cac:Country/cbc:Name" />
          <br />
        </xsl:if>
      </xsl:for-each>
    </td>
  </xsl:template>
  <xsl:template name="TransportMode">
    <xsl:param name="TransportModeType" />
    <xsl:choose>
      <xsl:when test="$TransportModeType=1">Denizyolu</xsl:when>
      <xsl:when test="$TransportModeType=2">Demiryolu</xsl:when>
      <xsl:when test="$TransportModeType=3">Karayolu</xsl:when>
      <xsl:when test="$TransportModeType=4">Havayolu</xsl:when>
      <xsl:when test="$TransportModeType=5">Posta</xsl:when>
      <xsl:when test="$TransportModeType=6">Çok araçlı</xsl:when>
      <xsl:when test="$TransportModeType=7">Sabit taşıma tesisleri</xsl:when>
      <xsl:when test="$TransportModeType=8">İç su taşımacılığı</xsl:when>
      <xsl:otherwise>
        <xsl:value-of select="$TransportModeType" />
      </xsl:otherwise>
    </xsl:choose>
  </xsl:template>
  <xsl:template name="Packaging">
    <xsl:param name="PackagingType" />
    <xsl:choose>
      <xsl:when test="$PackagingType='1A'">Drum, steel</xsl:when>
      <xsl:when test="$PackagingType='1B'">Drum, aluminium</xsl:when>
      <xsl:when test="$PackagingType='1D'">Drum, plywood</xsl:when>
      <xsl:when test="$PackagingType='1F'">Container, flexible</xsl:when>
      <xsl:when test="$PackagingType='1G'">Drum, fibre</xsl:when>
      <xsl:when test="$PackagingType='1W'">Drum, wooden</xsl:when>
      <xsl:when test="$PackagingType='2C'">Barrel, wooden</xsl:when>
      <xsl:when test="$PackagingType='3A'">Jerrican, steel</xsl:when>
      <xsl:when test="$PackagingType='3H'">Jerrican, plastic</xsl:when>
      <xsl:when test="$PackagingType='43'">Bag, super bulk</xsl:when>
      <xsl:when test="$PackagingType='44'">Bag, polybag</xsl:when>
      <xsl:when test="$PackagingType='4A'">Box, steel</xsl:when>
      <xsl:when test="$PackagingType='4B'">Box, aluminium</xsl:when>
      <xsl:when test="$PackagingType='4C'">Box, natural wood</xsl:when>
      <xsl:when test="$PackagingType='4D'">Box, plywood</xsl:when>
      <xsl:when test="$PackagingType='4F'">Box, reconstituted wood</xsl:when>
      <xsl:when test="$PackagingType='4G'">Box, fibreboard</xsl:when>
      <xsl:when test="$PackagingType='4H'">Box, plastic</xsl:when>
      <xsl:when test="$PackagingType='5H'">Bag, woven plastic</xsl:when>
      <xsl:when test="$PackagingType='5L'">Bag, textile</xsl:when>
      <xsl:when test="$PackagingType='5M'">Bag, paper</xsl:when>
      <xsl:when test="$PackagingType='6H'">Composite packaging, plastic receptacle</xsl:when>
      <xsl:when test="$PackagingType='6P'">Composite packaging, glass receptacle</xsl:when>
      <xsl:when test="$PackagingType='7A'">Case, car</xsl:when>
      <xsl:when test="$PackagingType='7B'">Case, wooden</xsl:when>
      <xsl:when test="$PackagingType='8A'">Pallet, wooden</xsl:when>
      <xsl:when test="$PackagingType='8B'">Crate, wooden</xsl:when>
      <xsl:when test="$PackagingType='8C'">Bundle, wooden</xsl:when>
      <xsl:when test="$PackagingType='AA'">Intermediate bulk container, rigid plastic</xsl:when>
      <xsl:when test="$PackagingType='AB'">Receptacle, fibre</xsl:when>
      <xsl:when test="$PackagingType='AC'">Receptacle, paper</xsl:when>
      <xsl:when test="$PackagingType='AD'">Receptacle, wooden</xsl:when>
      <xsl:when test="$PackagingType='AE'">Aerosol</xsl:when>
      <xsl:when test="$PackagingType='AF'">Pallet, modular, collars 80cms * 60cms</xsl:when>
      <xsl:when test="$PackagingType='AG'">Pallet, shrinkwrapped</xsl:when>
      <xsl:when test="$PackagingType='AH'">Pallet, 100cms * 110cms</xsl:when>
      <xsl:when test="$PackagingType='AI'">Clamshell</xsl:when>
      <xsl:when test="$PackagingType='AJ'">Cone</xsl:when>
      <xsl:when test="$PackagingType='AL'">Ball</xsl:when>
      <xsl:when test="$PackagingType='AM'">Ampoule, non-protected</xsl:when>
      <xsl:when test="$PackagingType='AP'">Ampoule, protected</xsl:when>
      <xsl:when test="$PackagingType='AT'">Atomizer</xsl:when>
      <xsl:when test="$PackagingType='AV'">Capsule</xsl:when>
      <xsl:when test="$PackagingType='B4'">Belt</xsl:when>
      <xsl:when test="$PackagingType='BA'">Barrel</xsl:when>
      <xsl:when test="$PackagingType='BB'">Bobbin</xsl:when>
      <xsl:when test="$PackagingType='BC'">Bottlecrate / bottlerack</xsl:when>
      <xsl:when test="$PackagingType='BD'">Board</xsl:when>
      <xsl:when test="$PackagingType='BE'">Bundle</xsl:when>
      <xsl:when test="$PackagingType='BF'">Balloon, non-protected</xsl:when>
      <xsl:when test="$PackagingType='BG'">Bag</xsl:when>
      <xsl:when test="$PackagingType='BH'">Bunch</xsl:when>
      <xsl:when test="$PackagingType='BI'">Bin</xsl:when>
      <xsl:when test="$PackagingType='BJ'">Bucket</xsl:when>
      <xsl:when test="$PackagingType='BK'">Basket</xsl:when>
      <xsl:when test="$PackagingType='BL'">Bale, compressed</xsl:when>
      <xsl:when test="$PackagingType='BM'">Basin</xsl:when>
      <xsl:when test="$PackagingType='BN'">Bale, non-compressed</xsl:when>
      <xsl:when test="$PackagingType='BO'">Bottle, non-protected, cylindrical</xsl:when>
      <xsl:when test="$PackagingType='BP'">Balloon, protected</xsl:when>
      <xsl:when test="$PackagingType='BQ'">Bottle, protected cylindrical</xsl:when>
      <xsl:when test="$PackagingType='BR'">Bar</xsl:when>
      <xsl:when test="$PackagingType='BS'">Bottle, non-protected, bulbous</xsl:when>
      <xsl:when test="$PackagingType='BT'">Bolt</xsl:when>
      <xsl:when test="$PackagingType='BU'">Butt</xsl:when>
      <xsl:when test="$PackagingType='BV'">Bottle, protected bulbous</xsl:when>
      <xsl:when test="$PackagingType='BW'">Box, for liquids</xsl:when>
      <xsl:when test="$PackagingType='BX'">Box</xsl:when>
      <xsl:when test="$PackagingType='BY'">Board, in bundle/bunch/truss</xsl:when>
      <xsl:when test="$PackagingType='BZ'">Bars, in bundle/bunch/truss</xsl:when>
      <xsl:when test="$PackagingType='CA'">Can, rectangular</xsl:when>
      <xsl:when test="$PackagingType='CB'">Crate, beer</xsl:when>
      <xsl:when test="$PackagingType='CC'">Churn</xsl:when>
      <xsl:when test="$PackagingType='CD'">Can, with handle and spout</xsl:when>
      <xsl:when test="$PackagingType='CE'">Creel</xsl:when>
      <xsl:when test="$PackagingType='CF'">Coffer</xsl:when>
      <xsl:when test="$PackagingType='CG'">Cage</xsl:when>
      <xsl:when test="$PackagingType='CH'">Chest</xsl:when>
      <xsl:when test="$PackagingType='CI'">Canister</xsl:when>
      <xsl:when test="$PackagingType='CJ'">Coffin</xsl:when>
      <xsl:when test="$PackagingType='CK'">Cask</xsl:when>
      <xsl:when test="$PackagingType='CL'">Coil</xsl:when>
      <xsl:when test="$PackagingType='CM'">Card</xsl:when>
      <xsl:when test="$PackagingType='CN'">Container, not otherwise specified as transport equipment</xsl:when>
      <xsl:when test="$PackagingType='CO'">Carboy, non-protected</xsl:when>
      <xsl:when test="$PackagingType='CP'">Carboy, protected</xsl:when>
      <xsl:when test="$PackagingType='CQ'">Cartridge</xsl:when>
      <xsl:when test="$PackagingType='CR'">Crate</xsl:when>
      <xsl:when test="$PackagingType='CS'">Case</xsl:when>
      <xsl:when test="$PackagingType='CT'">Carton</xsl:when>
      <xsl:when test="$PackagingType='CU'">Cup</xsl:when>
      <xsl:when test="$PackagingType='CV'">Cover</xsl:when>
      <xsl:when test="$PackagingType='CW'">Cage, roll</xsl:when>
      <xsl:when test="$PackagingType='CX'">Can, cylindrical</xsl:when>
      <xsl:when test="$PackagingType='CY'">Cylinder</xsl:when>
      <xsl:when test="$PackagingType='CZ'">Canvas</xsl:when>
      <xsl:when test="$PackagingType='DA'">Crate, multiple layer, plastic</xsl:when>
      <xsl:when test="$PackagingType='DB'">Crate, multiple layer, wooden</xsl:when>
      <xsl:when test="$PackagingType='DC'">Crate, multiple layer, cardboard</xsl:when>
      <xsl:when test="$PackagingType='DG'">Cage, Commonwealth Handling Equipment Pool (CHEP)</xsl:when>
      <xsl:when test="$PackagingType='DH'">Box, Commonwealth Handling Equipment Pool (CHEP), Eurobox</xsl:when>
      <xsl:when test="$PackagingType='DI'">Drum, iron</xsl:when>
      <xsl:when test="$PackagingType='DJ'">Demijohn, non-protected</xsl:when>
      <xsl:when test="$PackagingType='DK'">Crate, bulk, cardboard</xsl:when>
      <xsl:when test="$PackagingType='DL'">Crate, bulk, plastic</xsl:when>
      <xsl:when test="$PackagingType='DM'">Crate, bulk, wooden</xsl:when>
      <xsl:when test="$PackagingType='DN'">Dispenser</xsl:when>
      <xsl:when test="$PackagingType='DP'">Demijohn, protected</xsl:when>
      <xsl:when test="$PackagingType='DR'">Drum</xsl:when>
      <xsl:when test="$PackagingType='DS'">Tray, one layer no cover, plastic</xsl:when>
      <xsl:when test="$PackagingType='DT'">Tray, one layer no cover, wooden</xsl:when>
      <xsl:when test="$PackagingType='DU'">Tray, one layer no cover, polystyrene</xsl:when>
      <xsl:when test="$PackagingType='DV'">Tray, one layer no cover, cardboard</xsl:when>
      <xsl:when test="$PackagingType='DW'">Tray, two layers no cover, plastic tray</xsl:when>
      <xsl:when test="$PackagingType='DX'">Tray, two layers no cover, wooden</xsl:when>
      <xsl:when test="$PackagingType='DY'">Tray, two layers no cover, cardboard</xsl:when>
      <xsl:when test="$PackagingType='EC'">Bag, plastic</xsl:when>
      <xsl:when test="$PackagingType='ED'">Case, with pallet base</xsl:when>
      <xsl:when test="$PackagingType='EE'">Case, with pallet base, wooden</xsl:when>
      <xsl:when test="$PackagingType='EF'">Case, with pallet base, cardboard</xsl:when>
      <xsl:when test="$PackagingType='EG'">Case, with pallet base, plastic</xsl:when>
      <xsl:when test="$PackagingType='EH'">Case, with pallet base, metal</xsl:when>
      <xsl:when test="$PackagingType='EI'">Case, isothermic</xsl:when>
      <xsl:when test="$PackagingType='EN'">Envelope</xsl:when>
      <xsl:when test="$PackagingType='FB'">Flexibag</xsl:when>
      <xsl:when test="$PackagingType='FC'">Crate, fruit</xsl:when>
      <xsl:when test="$PackagingType='FD'">Crate, framed</xsl:when>
      <xsl:when test="$PackagingType='FE'">Flexitank</xsl:when>
      <xsl:when test="$PackagingType='FI'">Firkin</xsl:when>
      <xsl:when test="$PackagingType='FL'">Flask</xsl:when>
      <xsl:when test="$PackagingType='FO'">Footlocker</xsl:when>
      <xsl:when test="$PackagingType='FP'">Filmpack</xsl:when>
      <xsl:when test="$PackagingType='FR'">Frame</xsl:when>
      <xsl:when test="$PackagingType='FT'">Foodtainer</xsl:when>
      <xsl:when test="$PackagingType='FW'">Cart, flatbed</xsl:when>
      <xsl:when test="$PackagingType='FX'">Bag, flexible container</xsl:when>
      <xsl:when test="$PackagingType='GB'">Bottle, gas</xsl:when>
      <xsl:when test="$PackagingType='GI'">Girder</xsl:when>
      <xsl:when test="$PackagingType='GL'">Container, gallon</xsl:when>
      <xsl:when test="$PackagingType='GR'">Receptacle, glass</xsl:when>
      <xsl:when test="$PackagingType='GU'">Tray, containing horizontally stacked flat items</xsl:when>
      <xsl:when test="$PackagingType='GY'">Bag, gunny</xsl:when>
      <xsl:when test="$PackagingType='GZ'">Girders, in bundle/bunch/truss</xsl:when>
      <xsl:when test="$PackagingType='HA'">Basket, with handle, plastic</xsl:when>
      <xsl:when test="$PackagingType='HB'">Basket, with handle, wooden</xsl:when>
      <xsl:when test="$PackagingType='HC'">Basket, with handle, cardboard</xsl:when>
      <xsl:when test="$PackagingType='HG'">Hogshead</xsl:when>
      <xsl:when test="$PackagingType='HN'">Hanger</xsl:when>
      <xsl:when test="$PackagingType='HR'">Hamper</xsl:when>
      <xsl:when test="$PackagingType='IA'">Package, display, wooden</xsl:when>
      <xsl:when test="$PackagingType='IB'">Package, display, cardboard</xsl:when>
      <xsl:when test="$PackagingType='IC'">Package, display, plastic</xsl:when>
      <xsl:when test="$PackagingType='ID'">Package, display, metal</xsl:when>
      <xsl:when test="$PackagingType='IE'">Package, show</xsl:when>
      <xsl:when test="$PackagingType='IF'">Package, flow</xsl:when>
      <xsl:when test="$PackagingType='IG'">Package, paper wrapped</xsl:when>
      <xsl:when test="$PackagingType='IH'">Drum, plastic</xsl:when>
      <xsl:when test="$PackagingType='IK'">Package, cardboard, with bottle grip-holes</xsl:when>
      <xsl:when test="$PackagingType='IL'">Tray, rigid, lidded stackable (CEN TS 14482:2002)</xsl:when>
      <xsl:when test="$PackagingType='IN'">Ingot</xsl:when>
      <xsl:when test="$PackagingType='IZ'">Ingots, in bundle/bunch/truss</xsl:when>
      <xsl:when test="$PackagingType='JB'">Bag, jumbo</xsl:when>
      <xsl:when test="$PackagingType='JC'">Jerrican, rectangular</xsl:when>
      <xsl:when test="$PackagingType='JG'">Jug</xsl:when>
      <xsl:when test="$PackagingType='JR'">Jar</xsl:when>
      <xsl:when test="$PackagingType='JT'">Jutebag</xsl:when>
      <xsl:when test="$PackagingType='JY'">Jerrican, cylindrical</xsl:when>
      <xsl:when test="$PackagingType='KG'">Keg</xsl:when>
      <xsl:when test="$PackagingType='KI'">Kit</xsl:when>
      <xsl:when test="$PackagingType='LE'">Luggage</xsl:when>
      <xsl:when test="$PackagingType='LG'">Log</xsl:when>
      <xsl:when test="$PackagingType='LT'">Lot</xsl:when>
      <xsl:when test="$PackagingType='LU'">Lug</xsl:when>
      <xsl:when test="$PackagingType='LV'">Liftvan</xsl:when>
      <xsl:when test="$PackagingType='LZ'">Logs, in bundle/bunch/truss</xsl:when>
      <xsl:when test="$PackagingType='MA'">Crate, metal</xsl:when>
      <xsl:when test="$PackagingType='MB'">Bag, multiply</xsl:when>
      <xsl:when test="$PackagingType='MC'">Crate, milk</xsl:when>
      <xsl:when test="$PackagingType='ME'">Container, metal</xsl:when>
      <xsl:when test="$PackagingType='MR'">Receptacle, metal</xsl:when>
      <xsl:when test="$PackagingType='MS'">Sack, multi-wall</xsl:when>
      <xsl:when test="$PackagingType='MT'">Mat</xsl:when>
      <xsl:when test="$PackagingType='MW'">Receptacle, plastic wrapped</xsl:when>
      <xsl:when test="$PackagingType='MX'">Matchbox</xsl:when>
      <xsl:when test="$PackagingType='NA'">Not available</xsl:when>
      <xsl:when test="$PackagingType='NE'">Unpacked or unpackaged</xsl:when>
      <xsl:when test="$PackagingType='NF'">Unpacked or unpackaged, single unit</xsl:when>
      <xsl:when test="$PackagingType='NG'">Unpacked or unpackaged, multiple units</xsl:when>
      <xsl:when test="$PackagingType='NS'">Nest</xsl:when>
      <xsl:when test="$PackagingType='NT'">Net</xsl:when>
      <xsl:when test="$PackagingType='NU'">Net, tube, plastic</xsl:when>
      <xsl:when test="$PackagingType='NV'">Net, tube, textile</xsl:when>
      <xsl:when test="$PackagingType='OA'">Pallet, CHEP 40 cm x 60 cm</xsl:when>
      <xsl:when test="$PackagingType='OB'">Pallet, CHEP 80 cm x 120 cm</xsl:when>
      <xsl:when test="$PackagingType='OC'">Pallet, CHEP 100 cm x 120 cm</xsl:when>
      <xsl:when test="$PackagingType='OD'">Pallet, AS 4068-1993</xsl:when>
      <xsl:when test="$PackagingType='OE'">Pallet, ISO T11</xsl:when>
      <xsl:when test="$PackagingType='OF'">Platform, unspecified weight or dimension</xsl:when>
      <xsl:when test="$PackagingType='OK'">Block</xsl:when>
      <xsl:when test="$PackagingType='OT'">Octabin</xsl:when>
      <xsl:when test="$PackagingType='OU'">Container, outer</xsl:when>
      <xsl:when test="$PackagingType='P2'">Pan</xsl:when>
      <xsl:when test="$PackagingType='PA'">Packet</xsl:when>
      <xsl:when test="$PackagingType='PB'">Pallet, box Combined open-ended box and pallet</xsl:when>
      <xsl:when test="$PackagingType='PC'">Parcel</xsl:when>
      <xsl:when test="$PackagingType='PD'">Pallet, modular, collars 80cms * 100cms</xsl:when>
      <xsl:when test="$PackagingType='PE'">Pallet, modular, collars 80cms * 120cms</xsl:when>
      <xsl:when test="$PackagingType='PF'">Pen</xsl:when>
      <xsl:when test="$PackagingType='PG'">Plate</xsl:when>
      <xsl:when test="$PackagingType='PH'">Pitcher</xsl:when>
      <xsl:when test="$PackagingType='PI'">Pipe</xsl:when>
      <xsl:when test="$PackagingType='PJ'">Punnet</xsl:when>
      <xsl:when test="$PackagingType='PK'">Package</xsl:when>
      <xsl:when test="$PackagingType='PL'">Pail</xsl:when>
      <xsl:when test="$PackagingType='PN'">Plank</xsl:when>
      <xsl:when test="$PackagingType='PO'">Pouch</xsl:when>
      <xsl:when test="$PackagingType='PP'">Piece</xsl:when>
      <xsl:when test="$PackagingType='PR'">Receptacle, plastic</xsl:when>
      <xsl:when test="$PackagingType='PT'">Pot</xsl:when>
      <xsl:when test="$PackagingType='PU'">Tray</xsl:when>
      <xsl:when test="$PackagingType='PV'">Pipes, in bundle/bunch/truss</xsl:when>
      <xsl:when test="$PackagingType='PX'">Pallet</xsl:when>
      <xsl:when test="$PackagingType='PY'">Plates, in bundle/bunch/truss</xsl:when>
      <xsl:when test="$PackagingType='PZ'">Planks, in bundle/bunch/truss</xsl:when>
      <xsl:when test="$PackagingType='QA'">Drum, steel, non-removable head</xsl:when>
      <xsl:when test="$PackagingType='QB'">Drum, steel, removable head</xsl:when>
      <xsl:when test="$PackagingType='QC'">Drum, aluminium, non-removable head</xsl:when>
      <xsl:when test="$PackagingType='QD'">Drum, aluminium, removable head</xsl:when>
      <xsl:when test="$PackagingType='QF'">Drum, plastic, non-removable head</xsl:when>
      <xsl:when test="$PackagingType='QG'">Drum, plastic, removable head</xsl:when>
      <xsl:when test="$PackagingType='QH'">Barrel, wooden, bung type</xsl:when>
      <xsl:when test="$PackagingType='QJ'">Barrel, wooden, removable head</xsl:when>
      <xsl:when test="$PackagingType='QK'">Jerrican, steel, non-removable head</xsl:when>
      <xsl:when test="$PackagingType='QL'">Jerrican, steel, removable head</xsl:when>
      <xsl:when test="$PackagingType='QM'">Jerrican, plastic, non-removable head</xsl:when>
      <xsl:when test="$PackagingType='QN'">Jerrican, plastic, removable head</xsl:when>
      <xsl:when test="$PackagingType='QP'">Box, wooden, natural wood, ordinary</xsl:when>
      <xsl:when test="$PackagingType='QQ'">Box, wooden, natural wood, with sift proof walls</xsl:when>
      <xsl:when test="$PackagingType='QR'">Box, plastic, expanded</xsl:when>
      <xsl:when test="$PackagingType='QS'">Box, plastic, solid</xsl:when>
      <xsl:when test="$PackagingType='RD'">Rod</xsl:when>
      <xsl:when test="$PackagingType='RG'">Ring</xsl:when>
      <xsl:when test="$PackagingType='RJ'">Rack, clothing hanger</xsl:when>
      <xsl:when test="$PackagingType='RK'">Rack</xsl:when>
      <xsl:when test="$PackagingType='RL'">Reel</xsl:when>
      <xsl:when test="$PackagingType='RO'">Roll</xsl:when>
      <xsl:when test="$PackagingType='RT'">Rednet</xsl:when>
      <xsl:when test="$PackagingType='RZ'">Rods, in bundle/bunch/truss</xsl:when>
      <xsl:when test="$PackagingType='SA'">Sack</xsl:when>
      <xsl:when test="$PackagingType='SB'">Slab</xsl:when>
      <xsl:when test="$PackagingType='SC'">Crate, shallow</xsl:when>
      <xsl:when test="$PackagingType='SD'">Spindle</xsl:when>
      <xsl:when test="$PackagingType='SE'">Sea-chest</xsl:when>
      <xsl:when test="$PackagingType='SH'">Sachet</xsl:when>
      <xsl:when test="$PackagingType='SI'">Skid</xsl:when>
      <xsl:when test="$PackagingType='SK'">Case, skeleton</xsl:when>
      <xsl:when test="$PackagingType='SL'">Slipsheet</xsl:when>
      <xsl:when test="$PackagingType='SM'">Sheetmetal</xsl:when>
      <xsl:when test="$PackagingType='SO'">Spool</xsl:when>
      <xsl:when test="$PackagingType='SP'">Sheet, plastic wrapping</xsl:when>
      <xsl:when test="$PackagingType='SS'">Case, steel</xsl:when>
      <xsl:when test="$PackagingType='ST'">Sheet</xsl:when>
      <xsl:when test="$PackagingType='SU'">Suitcase</xsl:when>
      <xsl:when test="$PackagingType='SV'">Envelope, steel</xsl:when>
      <xsl:when test="$PackagingType='SW'">Shrinkwrapped</xsl:when>
      <xsl:when test="$PackagingType='SX'">Set</xsl:when>
      <xsl:when test="$PackagingType='SY'">Sleeve</xsl:when>
      <xsl:when test="$PackagingType='SZ'">Sheets, in bundle/bunch/truss</xsl:when>
      <xsl:when test="$PackagingType='T1'">Tablet</xsl:when>
      <xsl:when test="$PackagingType='TB'">Tub</xsl:when>
      <xsl:when test="$PackagingType='TC'">Tea-chest</xsl:when>
      <xsl:when test="$PackagingType='TD'">Tube, collapsible</xsl:when>
      <xsl:when test="$PackagingType='TE'">Tyre</xsl:when>
      <xsl:when test="$PackagingType='TG'">Tank container, generic</xsl:when>
      <xsl:when test="$PackagingType='TI'">Tierce</xsl:when>
      <xsl:when test="$PackagingType='TK'">Tank, rectangular</xsl:when>
      <xsl:when test="$PackagingType='TL'">Tub, with lid</xsl:when>
      <xsl:when test="$PackagingType='TN'">Tin</xsl:when>
      <xsl:when test="$PackagingType='TO'">Tun</xsl:when>
      <xsl:when test="$PackagingType='TR'">Trunk</xsl:when>
      <xsl:when test="$PackagingType='TS'">Truss</xsl:when>
      <xsl:when test="$PackagingType='TT'">Bag, tote</xsl:when>
      <xsl:when test="$PackagingType='TU'">Tube</xsl:when>
      <xsl:when test="$PackagingType='TV'">Tube, with nozzle</xsl:when>
      <xsl:when test="$PackagingType='TW'">Pallet, triwall</xsl:when>
      <xsl:when test="$PackagingType='TY'">Tank, cylindrical</xsl:when>
      <xsl:when test="$PackagingType='TZ'">Tubes, in bundle/bunch/truss</xsl:when>
      <xsl:when test="$PackagingType='UC'">Uncaged</xsl:when>
      <xsl:when test="$PackagingType='UN'">Unit</xsl:when>
      <xsl:when test="$PackagingType='VA'">Vat</xsl:when>
      <xsl:when test="$PackagingType='VG'">Bulk, gas (at 1031 mbar and 15Â°C)</xsl:when>
      <xsl:when test="$PackagingType='VI'">Vial</xsl:when>
      <xsl:when test="$PackagingType='VK'">Vanpack</xsl:when>
      <xsl:when test="$PackagingType='VL'">Bulk, liquid</xsl:when>
      <xsl:when test="$PackagingType='VO'">Bulk, solid, large particles (Â“nodulesÂ”)</xsl:when>
      <xsl:when test="$PackagingType='VP'">Vacuum-packed</xsl:when>
      <xsl:when test="$PackagingType='VQ'">Bulk, liquefied gas (at abnormal temperature/pressure)</xsl:when>
      <xsl:when test="$PackagingType='VN'">Vehicle</xsl:when>
      <xsl:when test="$PackagingType='VR'">Bulk, solid, granular particles (Â“grainsÂ”)</xsl:when>
      <xsl:when test="$PackagingType='VS'">Bulk, scrap metal</xsl:when>
      <xsl:when test="$PackagingType='VY'">Bulk, solid, fine particles (Â“powdersÂ”)</xsl:when>
      <xsl:when test="$PackagingType='WA'">Intermediate bulk container</xsl:when>
      <xsl:when test="$PackagingType='WB'">Wickerbottle</xsl:when>
      <xsl:when test="$PackagingType='WC'">Intermediate bulk container, steel</xsl:when>
      <xsl:when test="$PackagingType='WD'">Intermediate bulk container, aluminium</xsl:when>
      <xsl:when test="$PackagingType='WF'">Intermediate bulk container, metal</xsl:when>
      <xsl:when test="$PackagingType='WG'">Intermediate bulk container, steel, pressurised &gt; 10 kpa</xsl:when>
      <xsl:when test="$PackagingType='WH'">Intermediate bulk container, aluminium, pressurised &gt; 10 kpa</xsl:when>
      <xsl:when test="$PackagingType='WJ'">Intermediate bulk container, metal, pressure 10 kpa</xsl:when>
      <xsl:when test="$PackagingType='WK'">Intermediate bulk container, steel, liquid</xsl:when>
      <xsl:when test="$PackagingType='WL'">Intermediate bulk container, aluminium, liquid</xsl:when>
      <xsl:when test="$PackagingType='WM'">Intermediate bulk container, metal, liquid</xsl:when>
      <xsl:when test="$PackagingType='WN'">Intermediate bulk container, woven plastic, without coat/liner</xsl:when>
      <xsl:when test="$PackagingType='WP'">Intermediate bulk container, woven plastic, coated</xsl:when>
      <xsl:when test="$PackagingType='WQ'">Intermediate bulk container, woven plastic, with liner</xsl:when>
      <xsl:when test="$PackagingType='WR'">Intermediate bulk container, woven plastic, coated and liner</xsl:when>
      <xsl:when test="$PackagingType='WS'">Intermediate bulk container, plastic film</xsl:when>
      <xsl:when test="$PackagingType='WT'">Intermediate bulk container, textile with out coat/liner</xsl:when>
      <xsl:when test="$PackagingType='WU'">Intermediate bulk container, natural wood, with inner liner</xsl:when>
      <xsl:when test="$PackagingType='WV'">Intermediate bulk container, textile, coated</xsl:when>
      <xsl:when test="$PackagingType='WW'">Intermediate bulk container, textile, with liner</xsl:when>
      <xsl:when test="$PackagingType='WX'">Intermediate bulk container, textile, coated and liner</xsl:when>
      <xsl:when test="$PackagingType='WY'">Intermediate bulk container, plywood, with inner liner</xsl:when>
      <xsl:when test="$PackagingType='WZ'">Intermediate bulk container, reconstituted wood, with inner liner</xsl:when>
      <xsl:when test="$PackagingType='XA'">Bag, woven plastic, without inner coat/liner</xsl:when>
      <xsl:when test="$PackagingType='XB'">Bag, woven plastic, sift proof</xsl:when>
      <xsl:when test="$PackagingType='XC'">Bag, woven plastic, water resistant</xsl:when>
      <xsl:when test="$PackagingType='XD'">Bag, plastics film</xsl:when>
      <xsl:when test="$PackagingType='XF'">Bag, textile, without inner coat/liner</xsl:when>
      <xsl:when test="$PackagingType='XG'">Bag, textile, sift proof</xsl:when>
      <xsl:when test="$PackagingType='XH'">Bag, textile, water resistant</xsl:when>
      <xsl:when test="$PackagingType='XJ'">Bag, paper, multi-wall</xsl:when>
      <xsl:when test="$PackagingType='XK'">Bag, paper, multi-wall, water resistant</xsl:when>
      <xsl:when test="$PackagingType='YA'">Composite packaging, plastic receptacle in steel drum</xsl:when>
      <xsl:when test="$PackagingType='YB'">Composite packaging, plastic receptacle in steel crate box</xsl:when>
      <xsl:when test="$PackagingType='YC'">Composite packaging, plastic receptacle in aluminium drum</xsl:when>
      <xsl:when test="$PackagingType='YD'">Composite packaging, plastic receptacle in aluminium crate</xsl:when>
      <xsl:when test="$PackagingType='YF'">Composite packaging, plastic receptacle in wooden box</xsl:when>
      <xsl:when test="$PackagingType='YG'">Composite packaging, plastic receptacle in plywood drum</xsl:when>
      <xsl:when test="$PackagingType='YH'">Composite packaging, plastic receptacle in plywood box</xsl:when>
      <xsl:when test="$PackagingType='YJ'">Composite packaging, plastic receptacle in fibre drum</xsl:when>
      <xsl:when test="$PackagingType='YK'">Composite packaging, plastic receptacle in fibreboard box</xsl:when>
      <xsl:when test="$PackagingType='YL'">Composite packaging, plastic receptacle in plastic drum</xsl:when>
      <xsl:when test="$PackagingType='YM'">Composite packaging, plastic receptacle in solid plastic box</xsl:when>
      <xsl:when test="$PackagingType='YN'">Composite packaging, glass receptacle in steel drum</xsl:when>
      <xsl:when test="$PackagingType='YP'">Composite packaging, glass receptacle in steel crate box</xsl:when>
      <xsl:when test="$PackagingType='YQ'">Composite packaging, glass receptacle in aluminium drum</xsl:when>
      <xsl:when test="$PackagingType='YR'">Composite packaging, glass receptacle in aluminium crate</xsl:when>
      <xsl:when test="$PackagingType='YS'">Composite packaging, glass receptacle in wooden box</xsl:when>
      <xsl:when test="$PackagingType='YT'">Composite packaging, glass receptacle in plywood drum</xsl:when>
      <xsl:when test="$PackagingType='YV'">Composite packaging, glass receptacle in wickerwork hamper</xsl:when>
      <xsl:when test="$PackagingType='YW'">Composite packaging, glass receptacle in fibre drum</xsl:when>
      <xsl:when test="$PackagingType='YX'">Composite packaging, glass receptacle in fibreboard box</xsl:when>
      <xsl:when test="$PackagingType='YY'">Composite packaging, glass receptacle in expandable plastic pack</xsl:when>
      <xsl:when test="$PackagingType='YZ'">Composite packaging, glass receptacle in solid plastic pack</xsl:when>
      <xsl:when test="$PackagingType='ZA'">Intermediate bulk container, paper, multi-wall</xsl:when>
      <xsl:when test="$PackagingType='ZB'">Bag, large</xsl:when>
      <xsl:when test="$PackagingType='ZC'">Intermediate bulk container, paper, multi-wall, water resistant</xsl:when>
      <xsl:when test="$PackagingType='ZD'">Intermediate bulk container, rigid plastic, with structural equipment, solids</xsl:when>
      <xsl:when test="$PackagingType='ZF'">Intermediate bulk container, rigid plastic, freestanding, solids</xsl:when>
      <xsl:when test="$PackagingType='ZG'">Intermediate bulk container, rigid plastic, with structural equipment, pressurised</xsl:when>
      <xsl:when test="$PackagingType='ZH'">Intermediate bulk container, rigid plastic, freestanding, pressurised</xsl:when>
      <xsl:when test="$PackagingType='ZJ'">Intermediate bulk container, rigid plastic, with structural equipment, liquids</xsl:when>
      <xsl:when test="$PackagingType='ZK'">Intermediate bulk container, rigid plastic, freestanding, liquids</xsl:when>
      <xsl:when test="$PackagingType='ZL'">Intermediate bulk container, composite, rigid plastic, solids</xsl:when>
      <xsl:when test="$PackagingType='ZM'">Intermediate bulk container, composite, flexible plastic, solids</xsl:when>
      <xsl:when test="$PackagingType='ZN'">Intermediate bulk container, composite, rigid plastic, pressurised</xsl:when>
      <xsl:when test="$PackagingType='ZP'">Intermediate bulk container, composite, flexible plastic, pressurised</xsl:when>
      <xsl:when test="$PackagingType='ZQ'">Intermediate bulk container, composite, rigid plastic, liquids</xsl:when>
      <xsl:when test="$PackagingType='ZR'">Intermediate bulk container, composite, flexible plastic, liquids</xsl:when>
      <xsl:when test="$PackagingType='ZS'">Intermediate bulk container, composite</xsl:when>
      <xsl:when test="$PackagingType='ZT'">Intermediate bulk container, fibreboard</xsl:when>
      <xsl:when test="$PackagingType='ZU'">Intermediate bulk container, flexible</xsl:when>
      <xsl:when test="$PackagingType='ZV'">Intermediate bulk container, metal, other than steel</xsl:when>
      <xsl:when test="$PackagingType='ZW'">Intermediate bulk container, natural wood</xsl:when>
      <xsl:when test="$PackagingType='ZX'">Intermediate bulk container, plywood</xsl:when>
      <xsl:when test="$PackagingType='ZY'">Intermediate bulk container, reconstituted wood</xsl:when>
      <xsl:otherwise>
        <xsl:value-of select="$PackagingType" />
      </xsl:otherwise>
    </xsl:choose>
  </xsl:template>
  <xsl:template name="Country">
    <xsl:param name="CountryType" />
    <xsl:choose>
      <xsl:when test="$CountryType='AF'">Afganistan</xsl:when>
      <xsl:when test="$CountryType='DE'">Almanya</xsl:when>
      <xsl:when test="$CountryType='AD'">Andorra</xsl:when>
      <xsl:when test="$CountryType='AO'">Angola</xsl:when>
      <xsl:when test="$CountryType='AG'">Antigua ve Barbuda</xsl:when>
      <xsl:when test="$CountryType='AR'">Arjantin</xsl:when>
      <xsl:when test="$CountryType='AL'">Arnavutluk</xsl:when>
      <xsl:when test="$CountryType='AW'">Aruba</xsl:when>
      <xsl:when test="$CountryType='AU'">Avustralya</xsl:when>
      <xsl:when test="$CountryType='AT'">Avusturya</xsl:when>
      <xsl:when test="$CountryType='AZ'">Azerbaycan</xsl:when>
      <xsl:when test="$CountryType='BS'">Bahamalar</xsl:when>
      <xsl:when test="$CountryType='BH'">Bahreyn</xsl:when>
      <xsl:when test="$CountryType='BD'">Bangladeş</xsl:when>
      <xsl:when test="$CountryType='BB'">Barbados</xsl:when>
      <xsl:when test="$CountryType='EH'">Batı Sahra (MA)</xsl:when>
      <xsl:when test="$CountryType='BE'">Belçika</xsl:when>
      <xsl:when test="$CountryType='BZ'">Belize</xsl:when>
      <xsl:when test="$CountryType='BJ'">Benin</xsl:when>
      <xsl:when test="$CountryType='BM'">Bermuda</xsl:when>
      <xsl:when test="$CountryType='BY'">Beyaz Rusya</xsl:when>
      <xsl:when test="$CountryType='BT'">Bhutan</xsl:when>
      <xsl:when test="$CountryType='AE'">Birleşik Arap Emirlikleri</xsl:when>
      <xsl:when test="$CountryType='US'">Birleşik Devletler</xsl:when>
      <xsl:when test="$CountryType='GB'">Birleşik Krallık</xsl:when>
      <xsl:when test="$CountryType='BO'">Bolivya</xsl:when>
      <xsl:when test="$CountryType='BA'">Bosna-Hersek</xsl:when>
      <xsl:when test="$CountryType='BW'">Botsvana</xsl:when>
      <xsl:when test="$CountryType='BR'">Brezilya</xsl:when>
      <xsl:when test="$CountryType='BN'">Bruney</xsl:when>
      <xsl:when test="$CountryType='BG'">Bulgaristan</xsl:when>
      <xsl:when test="$CountryType='BF'">Burkina Faso</xsl:when>
      <xsl:when test="$CountryType='BI'">Burundi</xsl:when>
      <xsl:when test="$CountryType='TD'">Çad</xsl:when>
      <xsl:when test="$CountryType='KY'">Cayman Adaları</xsl:when>
      <xsl:when test="$CountryType='GI'">Cebelitarık (GB)</xsl:when>
      <xsl:when test="$CountryType='CZ'">Çek Cumhuriyeti</xsl:when>
      <xsl:when test="$CountryType='DZ'">Cezayir</xsl:when>
      <xsl:when test="$CountryType='DJ'">Cibuti</xsl:when>
      <xsl:when test="$CountryType='CN'">Çin</xsl:when>
      <xsl:when test="$CountryType='DK'">Danimarka</xsl:when>
      <xsl:when test="$CountryType='CD'">Demokratik Kongo Cumhuriyeti</xsl:when>
      <xsl:when test="$CountryType='TL'">Doğu Timor</xsl:when>
      <xsl:when test="$CountryType='DO'">Dominik Cumhuriyeti</xsl:when>
      <xsl:when test="$CountryType='DM'">Dominika</xsl:when>
      <xsl:when test="$CountryType='EC'">Ekvador</xsl:when>
      <xsl:when test="$CountryType='GQ'">Ekvator Ginesi</xsl:when>
      <xsl:when test="$CountryType='SV'">El Salvador</xsl:when>
      <xsl:when test="$CountryType='ID'">Endonezya</xsl:when>
      <xsl:when test="$CountryType='ER'">Eritre</xsl:when>
      <xsl:when test="$CountryType='AM'">Ermenistan</xsl:when>
      <xsl:when test="$CountryType='MF'">Ermiş Martin (FR)</xsl:when>
      <xsl:when test="$CountryType='EE'">Estonya</xsl:when>
      <xsl:when test="$CountryType='ET'">Etiyopya</xsl:when>
      <xsl:when test="$CountryType='FK'">Falkland Adaları</xsl:when>
      <xsl:when test="$CountryType='FO'">Faroe Adaları (DK)</xsl:when>
      <xsl:when test="$CountryType='MA'">Fas</xsl:when>
      <xsl:when test="$CountryType='FJ'">Fiji</xsl:when>
      <xsl:when test="$CountryType='CI'">Fildişi Sahili</xsl:when>
      <xsl:when test="$CountryType='PH'">Filipinler</xsl:when>
      <xsl:when test="$CountryType='FI'">Finlandiya</xsl:when>
      <xsl:when test="$CountryType='FR'">Fransa</xsl:when>
      <xsl:when test="$CountryType='GF'">Fransız Guyanası (FR)</xsl:when>
      <xsl:when test="$CountryType='PF'">Fransız Polinezyası (FR)</xsl:when>
      <xsl:when test="$CountryType='GA'">Gabon</xsl:when>
      <xsl:when test="$CountryType='GM'">Gambiya</xsl:when>
      <xsl:when test="$CountryType='GH'">Gana</xsl:when>
      <xsl:when test="$CountryType='GN'">Gine</xsl:when>
      <xsl:when test="$CountryType='GW'">Gine Bissau</xsl:when>
      <xsl:when test="$CountryType='GD'">Grenada</xsl:when>
      <xsl:when test="$CountryType='GL'">Grönland (DK)</xsl:when>
      <xsl:when test="$CountryType='GP'">Guadeloupe (FR)</xsl:when>
      <xsl:when test="$CountryType='GT'">Guatemala</xsl:when>
      <xsl:when test="$CountryType='GG'">Guernsey (GB)</xsl:when>
      <xsl:when test="$CountryType='ZA'">Güney Afrika</xsl:when>
      <xsl:when test="$CountryType='KR'">Güney Kore</xsl:when>
      <xsl:when test="$CountryType='GE'">Gürcistan</xsl:when>
      <xsl:when test="$CountryType='GY'">Guyana</xsl:when>
      <xsl:when test="$CountryType='HT'">Haiti</xsl:when>
      <xsl:when test="$CountryType='IN'">Hindistan</xsl:when>
      <xsl:when test="$CountryType='HR'">Hırvatistan</xsl:when>
      <xsl:when test="$CountryType='NL'">Hollanda</xsl:when>
      <xsl:when test="$CountryType='HN'">Honduras</xsl:when>
      <xsl:when test="$CountryType='HK'">Hong Kong (CN)</xsl:when>
      <xsl:when test="$CountryType='VG'">İngiliz Virjin Adaları</xsl:when>
      <xsl:when test="$CountryType='IQ'">Irak</xsl:when>
      <xsl:when test="$CountryType='IR'">İran</xsl:when>
      <xsl:when test="$CountryType='IE'">İrlanda</xsl:when>
      <xsl:when test="$CountryType='ES'">İspanya</xsl:when>
      <xsl:when test="$CountryType='IL'">İsrail</xsl:when>
      <xsl:when test="$CountryType='SE'">İsveç</xsl:when>
      <xsl:when test="$CountryType='CH'">İsviçre</xsl:when>
      <xsl:when test="$CountryType='IT'">İtalya</xsl:when>
      <xsl:when test="$CountryType='IS'">İzlanda</xsl:when>
      <xsl:when test="$CountryType='JM'">Jamaika</xsl:when>
      <xsl:when test="$CountryType='JP'">Japonya</xsl:when>
      <xsl:when test="$CountryType='JE'">Jersey (GB)</xsl:when>
      <xsl:when test="$CountryType='KH'">Kamboçya</xsl:when>
      <xsl:when test="$CountryType='CM'">Kamerun</xsl:when>
      <xsl:when test="$CountryType='CA'">Kanada</xsl:when>
      <xsl:when test="$CountryType='ME'">Karadağ</xsl:when>
      <xsl:when test="$CountryType='QA'">Katar</xsl:when>
      <xsl:when test="$CountryType='KZ'">Kazakistan</xsl:when>
      <xsl:when test="$CountryType='KE'">Kenya</xsl:when>
      <xsl:when test="$CountryType='CY'">Kıbrıs</xsl:when>
      <xsl:when test="$CountryType='KG'">Kırgızistan</xsl:when>
      <xsl:when test="$CountryType='KI'">Kiribati</xsl:when>
      <xsl:when test="$CountryType='CO'">Kolombiya</xsl:when>
      <xsl:when test="$CountryType='KM'">Komorlar</xsl:when>
      <xsl:when test="$CountryType='CG'">Kongo Cumhuriyeti</xsl:when>
      <xsl:when test="$CountryType='KV'">Kosova (RS)</xsl:when>
      <xsl:when test="$CountryType='CR'">Kosta Rika</xsl:when>
      <xsl:when test="$CountryType='CU'">Küba</xsl:when>
      <xsl:when test="$CountryType='KW'">Kuveyt</xsl:when>
      <xsl:when test="$CountryType='KP'">Kuzey Kore</xsl:when>
      <xsl:when test="$CountryType='LA'">Laos</xsl:when>
      <xsl:when test="$CountryType='LS'">Lesoto</xsl:when>
      <xsl:when test="$CountryType='LV'">Letonya</xsl:when>
      <xsl:when test="$CountryType='LR'">Liberya</xsl:when>
      <xsl:when test="$CountryType='LY'">Libya</xsl:when>
      <xsl:when test="$CountryType='LI'">Lihtenştayn</xsl:when>
      <xsl:when test="$CountryType='LT'">Litvanya</xsl:when>
      <xsl:when test="$CountryType='LB'">Lübnan</xsl:when>
      <xsl:when test="$CountryType='LU'">Lüksemburg</xsl:when>
      <xsl:when test="$CountryType='HU'">Macaristan</xsl:when>
      <xsl:when test="$CountryType='MG'">Madagaskar</xsl:when>
      <xsl:when test="$CountryType='MO'">Makao (CN)</xsl:when>
      <xsl:when test="$CountryType='MK'">Makedonya</xsl:when>
      <xsl:when test="$CountryType='MW'">Malavi</xsl:when>
      <xsl:when test="$CountryType='MV'">Maldivler</xsl:when>
      <xsl:when test="$CountryType='MY'">Malezya</xsl:when>
      <xsl:when test="$CountryType='ML'">Mali</xsl:when>
      <xsl:when test="$CountryType='MT'">Malta</xsl:when>
      <xsl:when test="$CountryType='IM'">Man Adası (GB)</xsl:when>
      <xsl:when test="$CountryType='MH'">Marshall Adaları</xsl:when>
      <xsl:when test="$CountryType='MQ'">Martinique (FR)</xsl:when>
      <xsl:when test="$CountryType='MU'">Mauritius</xsl:when>
      <xsl:when test="$CountryType='YT'">Mayotte (FR)</xsl:when>
      <xsl:when test="$CountryType='MX'">Meksika</xsl:when>
      <xsl:when test="$CountryType='FM'">Mikronezya</xsl:when>
      <xsl:when test="$CountryType='EG'">Mısır</xsl:when>
      <xsl:when test="$CountryType='MN'">Moğolistan</xsl:when>
      <xsl:when test="$CountryType='MD'">Moldova</xsl:when>
      <xsl:when test="$CountryType='MC'">Monako</xsl:when>
      <xsl:when test="$CountryType='MR'">Moritanya</xsl:when>
      <xsl:when test="$CountryType='MZ'">Mozambik</xsl:when>
      <xsl:when test="$CountryType='MM'">Myanmar</xsl:when>
      <xsl:when test="$CountryType='NA'">Namibya</xsl:when>
      <xsl:when test="$CountryType='NR'">Nauru</xsl:when>
      <xsl:when test="$CountryType='NP'">Nepal</xsl:when>
      <xsl:when test="$CountryType='NE'">Nijer</xsl:when>
      <xsl:when test="$CountryType='NG'">Nijerya</xsl:when>
      <xsl:when test="$CountryType='NI'">Nikaragua</xsl:when>
      <xsl:when test="$CountryType='NO'">Norveç</xsl:when>
      <xsl:when test="$CountryType='CF'">Orta Afrika Cumhuriyeti</xsl:when>
      <xsl:when test="$CountryType='UZ'">Özbekistan</xsl:when>
      <xsl:when test="$CountryType='PK'">Pakistan</xsl:when>
      <xsl:when test="$CountryType='PW'">Palau</xsl:when>
      <xsl:when test="$CountryType='PA'">Panama</xsl:when>
      <xsl:when test="$CountryType='PG'">Papua Yeni Gine</xsl:when>
      <xsl:when test="$CountryType='PY'">Paraguay</xsl:when>
      <xsl:when test="$CountryType='PE'">Peru</xsl:when>
      <xsl:when test="$CountryType='PL'">Polonya</xsl:when>
      <xsl:when test="$CountryType='PT'">Portekiz</xsl:when>
      <xsl:when test="$CountryType='PR'">Porto Riko (US)</xsl:when>
      <xsl:when test="$CountryType='RE'">Réunion (FR)</xsl:when>
      <xsl:when test="$CountryType='RO'">Romanya</xsl:when>
      <xsl:when test="$CountryType='RW'">Ruanda</xsl:when>
      <xsl:when test="$CountryType='RU'">Rusya</xsl:when>
      <xsl:when test="$CountryType='BL'">Saint Barthélemy (FR)</xsl:when>
      <xsl:when test="$CountryType='KN'">Saint Kitts ve Nevis</xsl:when>
      <xsl:when test="$CountryType='LC'">Saint Lucia</xsl:when>
      <xsl:when test="$CountryType='PM'">Saint Pierre ve Miquelon (FR)</xsl:when>
      <xsl:when test="$CountryType='VC'">Saint Vincent ve Grenadinler</xsl:when>
      <xsl:when test="$CountryType='WS'">Samoa</xsl:when>
      <xsl:when test="$CountryType='SM'">San Marino</xsl:when>
      <xsl:when test="$CountryType='ST'">São Tomé ve Príncipe</xsl:when>
      <xsl:when test="$CountryType='SN'">Senegal</xsl:when>
      <xsl:when test="$CountryType='SC'">Seyşeller</xsl:when>
      <xsl:when test="$CountryType='SL'">Sierra Leone</xsl:when>
      <xsl:when test="$CountryType='CL'">Şili</xsl:when>
      <xsl:when test="$CountryType='SG'">Singapur</xsl:when>
      <xsl:when test="$CountryType='RS'">Sırbistan</xsl:when>
      <xsl:when test="$CountryType='SK'">Slovakya Cumhuriyeti</xsl:when>
      <xsl:when test="$CountryType='SI'">Slovenya</xsl:when>
      <xsl:when test="$CountryType='SB'">Solomon Adaları</xsl:when>
      <xsl:when test="$CountryType='SO'">Somali</xsl:when>
      <xsl:when test="$CountryType='SS'">South Sudan</xsl:when>
      <xsl:when test="$CountryType='SJ'">Spitsbergen (NO)</xsl:when>
      <xsl:when test="$CountryType='LK'">Sri Lanka</xsl:when>
      <xsl:when test="$CountryType='SD'">Sudan</xsl:when>
      <xsl:when test="$CountryType='SR'">Surinam</xsl:when>
      <xsl:when test="$CountryType='SY'">Suriye</xsl:when>
      <xsl:when test="$CountryType='SA'">Suudi Arabistan</xsl:when>
      <xsl:when test="$CountryType='SZ'">Svaziland</xsl:when>
      <xsl:when test="$CountryType='TJ'">Tacikistan</xsl:when>
      <xsl:when test="$CountryType='TZ'">Tanzanya</xsl:when>
      <xsl:when test="$CountryType='TH'">Tayland</xsl:when>
      <xsl:when test="$CountryType='TW'">Tayvan</xsl:when>
      <xsl:when test="$CountryType='TG'">Togo</xsl:when>
      <xsl:when test="$CountryType='TO'">Tonga</xsl:when>
      <xsl:when test="$CountryType='TT'">Trinidad ve Tobago</xsl:when>
      <xsl:when test="$CountryType='TN'">Tunus</xsl:when>
      <xsl:when test="$CountryType='TR'">Türkiye</xsl:when>
      <xsl:when test="$CountryType='TM'">Türkmenistan</xsl:when>
      <xsl:when test="$CountryType='TC'">Turks ve Caicos</xsl:when>
      <xsl:when test="$CountryType='TV'">Tuvalu</xsl:when>
      <xsl:when test="$CountryType='UG'">Uganda</xsl:when>
      <xsl:when test="$CountryType='UA'">Ukrayna</xsl:when>
      <xsl:when test="$CountryType='OM'">Umman</xsl:when>
      <xsl:when test="$CountryType='JO'">Ürdün</xsl:when>
      <xsl:when test="$CountryType='UY'">Uruguay</xsl:when>
      <xsl:when test="$CountryType='VU'">Vanuatu</xsl:when>
      <xsl:when test="$CountryType='VA'">Vatikan</xsl:when>
      <xsl:when test="$CountryType='VE'">Venezuela</xsl:when>
      <xsl:when test="$CountryType='VN'">Vietnam</xsl:when>
      <xsl:when test="$CountryType='WF'">Wallis ve Futuna (FR)</xsl:when>
      <xsl:when test="$CountryType='YE'">Yemen</xsl:when>
      <xsl:when test="$CountryType='NC'">Yeni Kaledonya (FR)</xsl:when>
      <xsl:when test="$CountryType='NZ'">Yeni Zelanda</xsl:when>
      <xsl:when test="$CountryType='CV'">Yeşil Burun Adaları</xsl:when>
      <xsl:when test="$CountryType='GR'">Yunanistan</xsl:when>
      <xsl:when test="$CountryType='ZM'">Zambiya</xsl:when>
      <xsl:when test="$CountryType='ZW'">Zimbabve</xsl:when>
      <xsl:otherwise>
        <xsl:value-of select="$CountryType" />
      </xsl:otherwise>
    </xsl:choose>
  </xsl:template>
  <xsl:template name="Party_Other">
    <xsl:param name="PartyType" />
    <xsl:for-each select="cbc:WebsiteURI">
      <tr align="left">
        <td>
          <xsl:text>Web Sitesi: </xsl:text>
          <xsl:value-of select="." />
        </td>
      </tr>
    </xsl:for-each>
    <xsl:for-each select="cac:Contact/cbc:ElectronicMail">
      <tr align="left">
        <td>
          <xsl:text>E-Posta: </xsl:text>
          <xsl:value-of select="." />
        </td>
      </tr>
    </xsl:for-each>
    <xsl:for-each select="cac:Contact">
      <xsl:if test="cbc:Telephone or cbc:Telefax">
        <tr align="left">
          <td style="width:469px; " align="left">
            <xsl:for-each select="cbc:Telephone">
              <xsl:text>Tel: </xsl:text>
              <xsl:apply-templates />
            </xsl:for-each>
            <xsl:for-each select="cbc:Telefax">
              <xsl:text> Fax: </xsl:text>
              <xsl:apply-templates />
            </xsl:for-each>
            <xsl:text> </xsl:text>
          </td>
        </tr>
      </xsl:if>
    </xsl:for-each>
    <xsl:if test="$PartyType!='TAXFREE' and $PartyType!='EXPORT'">
      <xsl:for-each select="cac:PartyTaxScheme/cac:TaxScheme/cbc:Name">
        <tr align="left">
          <td>
            <xsl:text>Vergi Dairesi: </xsl:text>
            <xsl:apply-templates />
          </td>
        </tr>
      </xsl:for-each>
      <xsl:for-each select="cac:PartyIdentification">
        <tr align="left">
          <td>
            <xsl:value-of select="cbc:ID/@schemeID" />
            <xsl:text>: </xsl:text>
            <xsl:value-of select="cbc:ID" />
          </td>
        </tr>
      </xsl:for-each>
    </xsl:if>
  </xsl:template>
  <xsl:template name="Curr_Type">
    <xsl:value-of select="format-number(., '###.##0,00', 'european')" />
    <xsl:if test="@currencyID">
      <xsl:text>
      </xsl:text>
      <xsl:choose>
        <xsl:when test="@currencyID = 'TRL' or @currencyID = 'TRY'">
          <xsl:text>TL</xsl:text>
        </xsl:when>
        <xsl:otherwise>
          <xsl:value-of select="@currencyID" />
        </xsl:otherwise>
      </xsl:choose>
    </xsl:if>
  </xsl:template>
  <xsl:template name="Curr_Type_Only">
    <xsl:if test="n1:Invoice/cac:LegalMonetaryTotal/cbc:PayableAmount/@currencyID">
      <xsl:text>
      </xsl:text>
      <xsl:choose>
        <xsl:when test="n1:Invoice/cac:LegalMonetaryTotal/cbc:PayableAmount/@currencyID = 'TRL' or &#xD;&#xA;								n1:Invoice/cac:LegalMonetaryTotal/cbc:PayableAmount/@currencyID = 'TRY'">
          <xsl:text>TL</xsl:text>
        </xsl:when>
        <xsl:otherwise>
          <xsl:value-of select="n1:Invoice/cac:LegalMonetaryTotal/cbc:PayableAmount/@currencyID" />
        </xsl:otherwise>
      </xsl:choose>
    </xsl:if>
  </xsl:template>
</xsl:stylesheet>