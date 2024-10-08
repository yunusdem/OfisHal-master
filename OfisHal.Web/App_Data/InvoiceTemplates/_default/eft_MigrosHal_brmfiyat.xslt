<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:cac="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2" xmlns:cbc="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2" xmlns:ccts="urn:un:unece:uncefact:documentation:2" xmlns:clm54217="urn:un:unece:uncefact:codelist:specification:54217:2001" xmlns:clm5639="urn:un:unece:uncefact:codelist:specification:5639:1988" xmlns:clm66411="urn:un:unece:uncefact:codelist:specification:66411:2001" xmlns:clmIANAMIMEMediaType="urn:un:unece:uncefact:codelist:specification:IANAMIMEMediaType:2003" xmlns:fn="http://www.w3.org/2005/xpath-functions" xmlns:link="http://www.xbrl.org/2003/linkbase" xmlns:n1="urn:oasis:names:specification:ubl:schema:xsd:Invoice-2" xmlns:qdt="urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2" xmlns:udt="urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2" xmlns:xbrldi="http://xbrl.org/2006/xbrldi" xmlns:xbrli="http://www.xbrl.org/2003/instance" xmlns:xdt="http://www.w3.org/2005/xpath-datatypes" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:xs="http://www.w3.org/2001/XMLSchema" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" exclude-result-prefixes="cac cbc ccts clm54217 clm5639 clm66411 clmIANAMIMEMediaType fn link n1 qdt udt xbrldi xbrli xdt xlink xs xsd xsi" xmlns:msxsl="urn:schemas-microsoft-com:xslt">
    <xsl:decimal-format name="european" decimal-separator="," grouping-separator="." NaN=""/>
    <xsl:output version="4.0" method="html" indent="no" encoding="UTF-8" doctype-public="-//W3C//DTD HTML 4.01 Transitional//EN" doctype-system="http://www.w3.org/TR/html4/loose.dtd"/>
    <xsl:param name="SV_OutputFormat" select="'HTML'"/>
    <xsl:variable name="XML" select="/"/>
    <xsl:variable name="linePerPage" select="100"/>
    <xsl:variable name="legalMonetary" select="n1:Invoice=/cac:LegalMonetaryTotal/cbc:AllowanceTotalAmount"/>
    <xsl:variable name="linediscount" select="sum(n1:Invoice/cac:InvoiceLine/cac:AllowanceCharge/cbc:Amount)"/>
    <xsl:variable name="footerNote" select="//n1:Invoice/cbc:Note[not(contains(.,'FOOTER2') or contains(.,'PLAKA'))]"/>
    <xsl:template match="/">
        <html>
            <head>
                <style type="text/css">
          body {background-color: #FFFFFF;font-family: Calibri !important;font-size: 11px;color: #666666;margin:0px}
          #container{width:900px;height:1040px;border-spacing: 0px;}
          .containerTr{float:left;border-spacing: 0px;}
          .invoiceLineMainTr{margin-top: 3px;float:left;border-spacing: 0px;}
          #invoiceTop{width:900px;}
          .capital{text-transform:capitalize;}
          .lower{text-transform:lowercase;}
          .invoiceCompany{width:900px;}
          .companyLogo{width:250px;}
          .companyInfo{width:520px;}
          #companyInfoUl{list-style-type:none;padding: 0px;}
          #companyInfoUl li{float:left;padding-top: 5px;padding-left: 25px;}
          .companyAdres{width:100% !important;text-transform:capitalize;}
          .companyNameP{color: #000000;font-size: 19px;}
          .invoiceInfo{width:900px;}
          .invoiceCustomer{float:left;width:40%;}
          .invoiceLogo{float:left;width:20%;}
          .invoiceLogo img{width: 91px;}
          .invoiceDetails{float:left;width:39%;}
          .customerTitle{   font-weight:bold;color:#000000; font-size: 14px;text-transform:capitalize;}
          #companyInfoTbl{width:100%;}
          .lbl{font-weight:bold;color:#000000;text-transform:none !important;}
          #eInvoiceTitle{color: #000000 !important;text-transform: none !important;margin: 0px;font-size: 12px;}
          #invoiceDetailTbl {margin-left: 55px;padding-left: 10px;border-left: 15px solid #6699FF;}
          .invoiceID{padding-left: 55px;color:#6699FF;font-weight:bold;font-size: 15px;}
          .invoiceDetailColor{color:#000000;font-weight:bold;}
          #ettn{border-top: 1px dashed #000000;border-bottom: 1px dashed #000000;height: 30px;width: 900px;}
          #ettn p{margin:0px;padding-top: 9px;padding-left: 6px;}
          #invoiceLines{margin-top:10px;}
          #lineTable{font-size: 13px;border: 1px solid #DCDCDB;text-align: left;border-collapse:collapse; color:#414141;}
          #lineTable th{background-color: #6699FF;color:white;height: 30px;text-align:center;padding: 3px;border: none;font-weight: bold;}
          #lineTable td{padding: 1px;border: 1px solid #DCDCDB;font-size: 10px;}
          #lineTable tr{padding: 0px;border: none;background-color: #fff;height: 25px;}
          .coloredTr{   background-color: #f6f6f6 !important;}
          #invoiceTotal{width: 900px;}
          #budgetContainerTable{margin-top:5px;float:right;font-size: 13px;border: 1px solid #DCDCDB;text-align: left;border-collapse: collapse;color:#414141;}
          #budgetContainerTable tr{padding: 0px;border: none;background-color: #fff;}
          #budgetContainerTable td{border: 1px solid #DCDCDB;font-size: 11px;width:100px;text-align:right;height: 17px;}
          #budgetContainerTable th{background-color: #6699FF;color:white;text-align:left;border-bottom: 1px solid #FFCB45;font-weight: bold;height: 19px;padding-left: 4px;padding-right: 4px;}
          .notesMainTr{border-spacing: 0px;height: 80px;position: static;bottom: 20px;}
          #notes{width:900px;}
          #notesTable{border-left: 15px solid #6699FF;width: 100%;padding-left: 8px;}
          .noteLbl{width: 16%;font-weight: bold;color: #000000;}
          .pageInfo{height: 20px;position: static;bottom: 0px;}
		  #totalTable {
          font-size:10px;
		  font-weight:bold;		  
		  font-family:'Tahoma';
		  border:0;
          }
        </style>
                <title>e-Fatura</title>
                <link rel="Stylesheet" type="text/css" href="ubl.css">  </link>
            </head>
            <body>
                <xsl:variable name="totalInvoiceLine" select="count(n1:Invoice/cac:InvoiceLine)"/>
                <xsl:variable name="invoicePageCount" select="ceiling($totalInvoiceLine div $linePerPage)"/>
                <xsl:call-template name="Paging">
                    <xsl:with-param name="count" select="$invoicePageCount"/>
                </xsl:call-template>
            </body>
        </html>
    </xsl:template>
    <xsl:template match="dateFormatter">
        <xsl:value-of select="substring(.,9,2)"/>-<xsl:value-of select="substring(.,6,2)"/>-<xsl:value-of select="substring(.,1,4)"/>
    </xsl:template>
    <xsl:template name="Paging">
        <xsl:param name="index" select="1"/>
        <xsl:param name="count" select="1"/>
        <xsl:if test="$index &lt;= $count">
            <xsl:for-each select="$XML">
                <table id="container">
                    <tr class="containerTr">
                        <td>
                            <table id="invoiceTop">
                                <tr class="invoiceCompany">
                                    <!-->
                                    <td align="center" class="companyLogo">
                                        <img alt="idea logo" width="250" src="data:image/gif;base64,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"/>
                                    </td>
                                    -->
                                    <td class="companyInfo">
                                        <ul id="companyInfoUl">
                                            <li class="companyAdres">
                                                <span class="lbl">Adres: </span>
                                                <xsl:if test="n1:Invoice/cac:AccountingSupplierParty/cac:Party/cac:PostalAddress/cbc:StreetName">
                                                    <xsl:value-of select="n1:Invoice/cac:AccountingSupplierParty/cac:Party/cac:PostalAddress/cbc:StreetName"/>
                                                    <xsl:text>&#160;</xsl:text>
                                                </xsl:if>
                                                <xsl:if test="n1:Invoice/cac:AccountingSupplierParty/cac:Party/cac:PostalAddress/cbc:BuildingName">
                                                    <xsl:value-of select="n1:Invoice/cac:AccountingSupplierParty/cac:Party/cac:PostalAddress/cbc:BuildingName"/>
                                                    <xsl:text>&#160;</xsl:text>
                                                </xsl:if>
                                                <xsl:if test="n1:Invoice/cac:AccountingSupplierParty/cac:Party/cac:PostalAddress/cbc:BuildingNumber">
                                                    <xsl:text>No:</xsl:text>
                                                    <xsl:value-of select="n1:Invoice/cac:AccountingSupplierParty/cac:Party/cac:PostalAddress/cbc:BuildingNumber"/>
                                                    <xsl:text>&#160;</xsl:text>
                                                </xsl:if>
                                                <xsl:if test="n1:Invoice/cac:AccountingSupplierParty/cac:Party/cac:PostalAddress/cbc:PostalZone">
                                                    <xsl:value-of select="n1:Invoice/cac:AccountingSupplierParty/cac:Party/cac:PostalAddress/cbc:PostalZone"/>
                                                    <xsl:text>&#160;</xsl:text>
                                                </xsl:if>
                                                <xsl:value-of select="n1:Invoice/cac:AccountingSupplierParty/cac:Party/cac:PostalAddress/cbc:CitySubdivisionName"/>
                                                <xsl:text>/</xsl:text>
                                                <xsl:value-of select="n1:Invoice/cac:AccountingSupplierParty/cac:Party/cac:PostalAddress/cbc:CityName"/>
                                            </li>
                                            <xsl:if test="n1:Invoice/cac:AccountingSupplierParty/cac:Party/cac:Contact/cbc:Telephone">
                                                <li>
                                                    <span class="lbl">Tel: </span>
                                                    <xsl:value-of select="n1:Invoice/cac:AccountingSupplierParty/cac:Party/cac:Contact/cbc:Telephone"/>
                                                </li>
                                            </xsl:if>
                                            <xsl:if test="n1:Invoice/cac:AccountingSupplierParty/cac:Party/cac:Contact/cbc:Telefax">
                                                <li>
                                                    <span class="lbl">Faks: </span>
                                                    <xsl:value-of select="n1:Invoice/cac:AccountingSupplierParty/cac:Party/cac:Contact/cbc:Telefax"/>
                                                </li>
                                            </xsl:if>
                                            <xsl:if test="n1:Invoice/cac:AccountingSupplierParty/cac:Party/cbc:WebsiteURI">
                                                <li class="lower">
                                                    <span class="lbl">Web: </span>
                                                    <xsl:value-of select="n1:Invoice/cac:AccountingSupplierParty/cac:Party/cbc:WebsiteURI"/>
                                                </li>
                                            </xsl:if>
                                            <xsl:if test="n1:Invoice/cac:AccountingSupplierParty/cac:Party/cac:Contact/cbc:ElectronicMail">
                                                <li class="lower">
                                                    <span class="lbl">e-Posta: </span>
                                                    <xsl:value-of select="n1:Invoice/cac:AccountingSupplierParty/cac:Party/cac:Contact/cbc:ElectronicMail"/>
                                                </li>
                                            </xsl:if>
                                            <xsl:if test="n1:Invoice/cac:AccountingSupplierParty/cac:Party/cac:PartyTaxScheme/cac:TaxScheme/cbc:Name">
                                                <li class="capital">
                                                    <span class="lbl">Vergi Dairesi: </span>
                                                    <xsl:value-of select="n1:Invoice/cac:AccountingSupplierParty/cac:Party/cac:PartyTaxScheme/cac:TaxScheme/cbc:Name"/>
                                                </li>
                                            </xsl:if>
                      <li></li>
                      <li></li>
                      <xsl:for-each select="//n1:Invoice/cac:AccountingSupplierParty/cac:Party/cac:PartyIdentification">
                        <xsl:if test="cbc:ID/@schemeID[not(contains(.,'MUSTERINO'))]">
                          <!--<xsl:if test="//n1:Invoice/cac:AccountingSupplierParty/cac:Party/cac:PartyIdentification/cbc:ID/@schemeID[contains(.,'VKN')]">
                          <li></li>
                        </xsl:if>-->
                          <li></li>
                          <li></li>
                          <li>
                            <span class="lbl">
                              <xsl:if test="cbc:ID/@schemeID[not(contains(.,'MUSTERINO'))]">
                                <xsl:value-of select="cbc:ID/@schemeID"/>:
                              </xsl:if>
                            </span>
                            <xsl:value-of select="cbc:ID"/>
                          </li>

                        </xsl:if>
                      </xsl:for-each>
                                        </ul>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr class="containerTr">
                        <td colspan="3">
                            <table class="companyNameLineTbl">
                                <tr>
                                    <td class="companyNameColor"/>
                                    <xsl:if test="n1:Invoice/cac:AccountingSupplierParty/cac:Party/cac:PartyName/cbc:Name">
                                        <td class="companyNameP">
                                            <xsl:value-of select="n1:Invoice/cac:AccountingSupplierParty/cac:Party/cac:PartyName/cbc:Name"/>
                                        </td>
                                    </xsl:if>
                                    <xsl:if test="n1:Invoice/cac:AccountingSupplierParty/cac:Party/cac:Person">
                                        <td class="companyNameP">
                                            <xsl:if test="n1:Invoice/cac:AccountingSupplierParty/cac:Party/cac:Person/Title">
                                                <xsl:value-of select="n1:Invoice/cac:AccountingSupplierParty/cac:Party/cac:Person/cbc:Title"/>
                                                <xsl:text>&#160;</xsl:text>
                                            </xsl:if>
                                            <xsl:value-of select="n1:Invoice/cac:AccountingSupplierParty/cac:Party/cac:Person/cbc:FirstName"/>
                                            <xsl:text>&#160;</xsl:text>
                                            <xsl:if test="n1:Invoice/cac:AccountingSupplierParty/cac:Party/cac:Person/MiddleName">
                                                <xsl:value-of select="n1:Invoice/cac:AccountingSupplierParty/cac:Party/cac:Person/cbc:MiddleName"/>
                                                <xsl:text>&#160;</xsl:text>
                                            </xsl:if>
                                            <xsl:value-of select="n1:Invoice/cac:AccountingSupplierParty/cac:Party/cac:Person/cbc:FamilyName"/>
                                            <xsl:text>&#160;</xsl:text>
                                            <xsl:if test="n1:Invoice/cac:AccountingSupplierParty/cac:Party/cac:Person/NameSuffix">
                                                <xsl:value-of select="n1:Invoice/cac:AccountingSupplierParty/cac:Party/cac:Person/cbc:NameSuffix"/>
                                            </xsl:if>
                                        </td>
                                    </xsl:if>
                                    <td class="companyNameColor"/>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr class="containerTr">
                        <td>
                            <table class="invoiceInfo">
                                <tr>
                                    <td class="invoiceCustomer">
                                        <table>
                                            <tr>
                                                <xsl:if test="n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:PartyName/cbc:Name">
                                                    <td class="customerTitle">
                                                        <xsl:value-of select="n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:PartyName/cbc:Name"/>
                                                    </td>
                                                </xsl:if>
                                                <!--<xsl:if test="n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:Person">
                          <td class="customerTitle">
                            <xsl:if test="n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:Person/Title">
                              <xsl:value-of select="n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:Person/cbc:Title"/>
                              <xsl:text>&#160;</xsl:text>
                            </xsl:if>
                            <xsl:value-of select="n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:Person/cbc:FirstName"/>
                            <xsl:text>&#160;</xsl:text>
                            <xsl:if test="n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:Person/MiddleName">
                              <xsl:value-of select="n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:Person/cbc:MiddleName"/>
                              <xsl:text>&#160;</xsl:text>
                            </xsl:if>
                            <xsl:value-of select="n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:Person/cbc:FamilyName"/>
                            <xsl:text>&#160;</xsl:text>
                            <xsl:if test="n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:Person/NameSuffix">
                              <xsl:value-of select="n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:Person/cbc:NameSuffix"/>
                            </xsl:if>
                          </td>
                        </xsl:if>-->
                                            </tr>
                                            <tr>
                                                <td>
                                                    <table id="customerInfoTbl">
                                                        <tr>
                                                            <td class="capital">
                                                                <span class="lbl">Adres: </span>
                                                                <xsl:if test="n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:PostalAddress/cbc:StreetName">
                                                                    <xsl:value-of select="n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:PostalAddress/cbc:StreetName"/>
                                                                    <xsl:text>&#160;</xsl:text>
                                                                </xsl:if>
                                                                <xsl:if test="n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:PostalAddress/cbc:BuildingName">
                                                                    <xsl:value-of select="n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:PostalAddress/cbc:BuildingName"/>
                                                                    <xsl:text>&#160;</xsl:text>
                                                                </xsl:if>
                                                                <xsl:if test="n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:PostalAddress/cbc:BuildingNumber">
                                                                    <xsl:text> No:</xsl:text>
                                                                    <xsl:value-of select="n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:PostalAddress/cbc:BuildingNumber"/>
                                                                    <xsl:text>&#160;</xsl:text>
                                                                </xsl:if>
                                                                <xsl:if test="n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:PostalAddress/cbc:PostalZone">
                                                                    <xsl:value-of select="n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:PostalAddress/cbc:PostalZone"/>
                                                                    <xsl:text>&#160;</xsl:text>
                                                                </xsl:if>
                                                                <xsl:value-of select="n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:PostalAddress/cbc:CitySubdivisionName"/>
                                                                <xsl:text>/</xsl:text>
                                                                <xsl:value-of select="n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:PostalAddress/cbc:CityName"/>
                                                            </td>
                                                        </tr>
                                                        <xsl:if test="n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:Contact/cbc:Telephone">
                                                            <tr>
                                                                <td>
                                                                    <xsl:if test="n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:Contact/cbc:Telephone">
                                                                        <span class="lbl">Tel: </span>
                                                                        <xsl:value-of select="n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:Contact/cbc:Telephone"/>
                                                                    </xsl:if>
                                                                    <xsl:if test="n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:Contact/cbc:Telefax">
                                                                        <xsl:text>&#160;</xsl:text>
                                                                        <span class="lbl">Faks: </span>
                                                                        <xsl:value-of select="n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:Contact/cbc:Telefax"/>
                                                                    </xsl:if>
                                                                </td>
                                                            </tr>
                                                        </xsl:if>
                                                        <xsl:if test="n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:Contact/cbc:ElectronicMail">
                              </xsl:if>
                                                        <xsl:if test="n1:Invoice/cac:AccountingCustomerParty/cac:Party/cbc:WebsiteURI">
                                                            <tr>
                                                                <td class="lower">
                                                                    <span class="lbl">Web: </span>
                                                                    <xsl:value-of select="n1:Invoice/cac:AccountingCustomerParty/cac:Party/cbc:WebsiteURI"/>
                                                                </td>
                                                            </tr>
                                                        </xsl:if>
                                                        <xsl:if test="n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:PartyTaxScheme/cac:TaxScheme/cbc:Name">
                                                            <tr>
                                                                <td class="capital">
                                                                    <span class="lbl">Vergi Dairesi: </span>
                                                                    <xsl:value-of select="n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:PartyTaxScheme/cac:TaxScheme/cbc:Name"/>
                                                                </td>
                                                            </tr>
                                                        </xsl:if>
                                                        <xsl:for-each select="//n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:PartyIdentification">
                                                            <tr>
                                                                <td>
                                                                    <span class="lbl">
                                                                        <xsl:value-of select="cbc:ID/@schemeID"/>:
                                  </span>
                                                                    <xsl:value-of select="cbc:ID"/>
                                                                </td>
                                                            </tr>
                                                        </xsl:for-each>
                            <xsl:if test="n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:AgentParty/cac:PartyIdentification/cbc:ID">
                              <tr>
                                <td class="capital">
                                  <span class="lbl">BAYINO: </span>
                                  <xsl:value-of select="n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:AgentParty/cac:PartyIdentification/cbc:ID"/>
                                </td>
                              </tr>
                            </xsl:if>
                                                    </table>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                    <td class="invoiceLogo" align="center">
                                        <img align="middle" alt="E-Fatura Logo" src="data:image/jpeg;base64,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"/>
                                        <h2 id="eInvoiceTitle" align="center">e-FATURA</h2>
                                    </td>
                                    <td class="invoiceDetails">
                                        <table>
                                            <tr>
                                                <td class="invoiceID">
                                                    <span class="invoiceDetailColor">Fatura No: </span>
                                                    <xsl:value-of select="n1:Invoice/cbc:ID"/>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <table id="invoiceDetailTbl">
                                                        <tr>
                                                            <td class="invoiceDetailColor">Özelleştirme No</td>
                                                            <td class="doubleDot">:</td>
                                                            <td>
                                                                <xsl:value-of select="n1:Invoice/cbc:CustomizationID"/>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="invoiceDetailColor">Senaryo</td>
                                                            <td class="doubleDot">:</td>
                                                            <td class="capital">
                                                                <xsl:value-of select="n1:Invoice/cbc:ProfileID"/>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="invoiceDetailColor">Fatura Tipi</td>
                                                            <td class="doubleDot">:</td>
                                                            <td class="capital">
                                                                <xsl:value-of select="n1:Invoice/cbc:InvoiceTypeCode"/>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="invoiceDetailColor">Fatura Tarihi</td>
                                                            <td class="doubleDot">:</td>
                                                            <td>
                                                                <xsl:for-each select="n1:Invoice/cbc:IssueDate">
                                                                    <xsl:value-of select="substring(.,9,2)"/>.<xsl:value-of select="substring(.,6,2)"/>.<xsl:value-of select="substring(.,1,4)"/>
                                                                </xsl:for-each>
                                                            </td>
                                                        </tr>
                                                        <xsl:for-each select="n1:Invoice/cac:DespatchDocumentReference">
                                                            <tr>
                                                                <td class="invoiceDetailColor">İrsaliye No</td>
                                                                <td class="doubleDot">:</td>
                                                                <td>
                                                                    <xsl:value-of select="cbc:ID"/>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td class="invoiceDetailColor">İrsaliye Tarihi</td>
                                                                <td class="doubleDot">:</td>
                                                                <td align="left">
                                                                    <xsl:for-each select="cbc:IssueDate">
                                                                        <xsl:value-of select="substring(.,9,2)"/>.<xsl:value-of select="substring(.,6,2)"/>.<xsl:value-of select="substring(.,1,4)"/>
                                                                    </xsl:for-each>
                                                                </td>
                                                            </tr>
                                                        </xsl:for-each>
                                                        <xsl:for-each select="n1:Invoice/cac:OrderReference">
                                                            <tr>
                                                                <td class="invoiceDetailColor">Sipariş No</td>
                                                                <td class="doubleDot">:</td>
                                                                <td>
                                                                    <xsl:value-of select="cbc:ID"/>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td class="invoiceDetailColor">Sipariş Tarihi</td>
                                                                <td class="doubleDot">:</td>
                                                                <td align="left">
                                                                    <xsl:for-each select="cbc:IssueDate">
                                                                        <xsl:value-of select="substring(.,9,2)"/>.<xsl:value-of select="substring(.,6,2)"/>.<xsl:value-of select="substring(.,1,4)"/>
                                                                    </xsl:for-each>
                                                                </td>
                                                            </tr>
                                                        </xsl:for-each>
                                                        <xsl:for-each select="n1:Invoice/cac:PaymentMeans/cbc:PaymentDueDate">
                                                            <tr>
                                                                <td class="invoiceDetailColor">Vade Tarihi</td>
                                                                <td class="doubleDot">:</td>
                                                                <td align="left">
                                                                    <xsl:for-each select="//n1:Invoice/cac:PaymentMeans/cbc:PaymentDueDate">
                                                                        <xsl:value-of select="substring(.,9,2)"/>.<xsl:value-of select="substring(.,6,2)"/>.<xsl:value-of select="substring(.,1,4)"/>
                                                                    </xsl:for-each>
                                                                </td>
                                                            </tr>
                                                        </xsl:for-each>
                            <xsl:for-each select="//n1:Invoice/cac:AccountingSupplierParty/cac:Party/cac:PartyIdentification">
                              <xsl:if test="cbc:ID/@schemeID[contains(.,'MUSTERINO')]">
                                <tr>
                                  <td class="invoiceDetailColor">Malveren No</td>
                                  <td class="doubleDot">:</td>
                                  <td align="left">
                                    <xsl:value-of select="cbc:ID"/>
                                  </td>
                                </tr>
                              </xsl:if>
                            </xsl:for-each>
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
                            <div id="ettn">
                                <p>
                                    <span class="lbl">ETTN: </span>
                                    <xsl:value-of select="n1:Invoice/cbc:UUID"/>
                                </p>
                            </div>
                        </td>
                    </tr>
          <tr class="invoiceLineMainTr">
            <td id="invoiceLines">
              <table id="lineTable" width="900">
                <tr>
                  <th style="width:15px;">S. No</th>
                  <th style="width:50px;">Satıcı Ürün Kodu</th>
                  <th style="width:50px;">Alıcı Ürün Kodu</th>
                  <th style="width:140px;">Mal Hizmet</th>
				  <th style="width:30px;">Kap</th>
				  <th style="width:30px;">Daralı</th>
				  <th style="width:30px;">Dara</th>
                  <th style="width:15px;">Miktar</th>
                  <th style="width:30px;">Birim</th>
                  <th style="width:58px;">Birim Fiyat</th>
                  <th style="width:30px;">İskonto oranı</th>
                  <th style="width:58px;">İskonto tutarı</th>
                  <th style="width:30px;">KDV oranı</th>
                  <th style="width:58px;">KDV Tutarı</th>
                  <th style="width:80px;">Mal Hizmet Tutarı</th>
                </tr>
                <xsl:for-each select="n1:Invoice/cac:InvoiceLine">
                  <xsl:variable name="linePosition" select="position()"></xsl:variable>
                  <xsl:variable name="tempPosition" select="($index - 1) * $linePerPage"></xsl:variable>
                  <xsl:variable name="tempPosition2" select="$index * $linePerPage"></xsl:variable>
                  <xsl:if test="$linePosition &gt; $tempPosition">
                    <xsl:if test="$linePosition &lt;= $tempPosition2">
                      <tr>
                        <td align="center">
                          <xsl:value-of select="./cbc:ID"/>
                        </td>
                        <td align="center">
                          <xsl:value-of select="./cac:Item/cac:SellersItemIdentification/cbc:ID"/>
                        </td>
                        <td align="center">
                          <xsl:value-of select="./cac:Item/cac:BuyersItemIdentification/cbc:ID"/>
                        </td>
                        <td>
                          <xsl:value-of select="./cac:Item/cbc:Name"/>
                        </td>
						<xsl:if test="//n1:Invoice/cac:InvoiceLine/cbc:Note and not(contains(.,'Not:'))">
							<xsl:variable name="pText" select="./cbc:Note"/>
								<xsl:variable name="pTrim" select="normalize-space($pText)"/>
								<xsl:variable name="pAdet" select="substring-before(concat($pTrim,' '),' ')"/>
								<xsl:variable name="pDaralıDara" select="substring-after(concat($pTrim,' '),' ')"/>
								<xsl:variable name="pDaralı" select="substring-before(concat($pDaralıDara,' '),' ')"/>
								<xsl:variable name="pDara" select="substring-after(concat($pDaralıDara,' '),' ')"/>
							<td align="center">
								<xsl:value-of select="$pAdet"/>
							</td>
							<td align="center">														
								<xsl:value-of select="$pDaralı"/>														
							</td>
							<td align="center">
								<xsl:value-of select="$pDara"/>
							</td>
						</xsl:if>
                        <td align="center">
                          <xsl:value-of select="format-number(./cbc:InvoicedQuantity, '###.###,000', 'european')"/>
                        </td>
                        <td align="center">
                          <xsl:if test="./cbc:InvoicedQuantity/@unitCode">
                            <xsl:for-each select="./cbc:InvoicedQuantity">
                              <xsl:text/>
                              <xsl:choose>
                                <xsl:when test="@unitCode  = 'CCT'">
                                  <xsl:text>Ton</xsl:text>
                                </xsl:when>
                                <xsl:when test="@unitCode  = '26'">
                                  <xsl:text>Ton</xsl:text>
                                </xsl:when>
                                <xsl:when test="@unitCode  = 'BX'">
                                  <xsl:text>Kutu</xsl:text>
                                </xsl:when>
                                <xsl:when test="@unitCode  = 'C62'">
                                  <xsl:text>Adet</xsl:text>
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
								<xsl:when test="@unitCode  = 'BE'">
									<xsl:text>Bağ</xsl:text>
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
                          <xsl:value-of select="format-number(./cac:Price/cbc:PriceAmount, '###.##0,0000000', 'european')"/>
                          <xsl:if test="./cac:Price/cbc:PriceAmount/@currencyID">
                            <xsl:if test='./cac:Price/cbc:PriceAmount/@currencyID = "TRY" '>
                              <xsl:text>&#160;TL</xsl:text>
                            </xsl:if>
                            <xsl:if test='./cac:Price/cbc:PriceAmount/@currencyID != "TRY"'>
                              <xsl:value-of select="./cac:Price/cbc:PriceAmount/@currencyID"/>
                            </xsl:if>
                          </xsl:if>
                        </td>
                        <td align="center">
                          <xsl:if test="./cac:AllowanceCharge/cbc:MultiplierFactorNumeric">
                            <xsl:value-of select="format-number(./cac:AllowanceCharge/cbc:MultiplierFactorNumeric * 100, '###.##0,00', 'european')"/>
                          </xsl:if>
                        </td>
                        <td align="right">
                          <xsl:if test="./cac:AllowanceCharge">
                            <xsl:value-of select="format-number(./cac:AllowanceCharge/cbc:Amount, '###.##0,00', 'european')"/>
                          </xsl:if>
                          <xsl:if test="./cac:AllowanceCharge/cbc:Amount/@currencyID">
                            <xsl:if test="./cac:AllowanceCharge/cbc:Amount/@currencyID = 'TRY'">
                              <xsl:text>&#160;TL</xsl:text>
                            </xsl:if>
                            <xsl:if test="./cac:AllowanceCharge/cbc:Amount/@currencyID != 'TRY'">
                              <xsl:value-of select="./cac:AllowanceCharge/cbc:Amount/@currencyID"/>
                            </xsl:if>
                          </xsl:if>
                        </td>
                        <td align="center">
                          <xsl:for-each select="./cac:TaxTotal">
                            <xsl:for-each select="cac:TaxSubtotal/cac:TaxCategory/cac:TaxScheme">
                              <xsl:if test="cbc:TaxTypeCode='0015' ">
                                <xsl:if test="../../cbc:Percent">
                                  <xsl:value-of select="format-number(../../cbc:Percent, '###.##0,00', 'european')"/>
                                </xsl:if>
                              </xsl:if>
                            </xsl:for-each>
                          </xsl:for-each>
                        </td>
                        <td align="right">
                          <xsl:for-each select="./cac:TaxTotal">
                            <xsl:for-each select="cac:TaxSubtotal/cac:TaxCategory/cac:TaxScheme">
                              <xsl:if test="cbc:TaxTypeCode='0015' ">
                                <xsl:value-of select="format-number(../../cbc:TaxAmount, '###.##0,00', 'european')"/>
                                <xsl:if test="../../cbc:TaxAmount/@currencyID">
                                  <xsl:if test="../../cbc:TaxAmount/@currencyID = 'TRY'">
                                    <xsl:text>&#160;TL</xsl:text>
                                  </xsl:if>
                                  <xsl:if test="../../cbc:TaxAmount/@currencyID != 'TRY'">
                                    <xsl:value-of select="../../cbc:TaxAmount/@currencyID"/>
                                  </xsl:if>
                                </xsl:if>
                              </xsl:if>
                            </xsl:for-each>
                          </xsl:for-each>
                        </td>
                        <td align="right">
                          <xsl:value-of select="format-number(./cbc:LineExtensionAmount, '###.##0,00', 'european')"/>
                          <xsl:if test="./cbc:LineExtensionAmount/@currencyID">
                            <xsl:if test="./cbc:LineExtensionAmount/@currencyID = 'TRY' ">
                              <xsl:text>&#160;TL</xsl:text>
                            </xsl:if>
                            <xsl:if test="./cbc:LineExtensionAmount/@currencyID != 'TRY' ">
                              <xsl:value-of select="./cbc:LineExtensionAmount/@currencyID"/>
                            </xsl:if>
                          </xsl:if>
                        </td>
                      </tr>
                    </xsl:if>
                  </xsl:if>
                </xsl:for-each>
				<tr>
                        <td> </td>
                        <td> </td>
                        <td> </td>
                        <td>
                          <span id="totalTable"> Toplam :</span>
                        </td>
						<xsl:if test="//n1:Invoice/cac:InvoiceLine/cbc:Note and not(contains(.,'Not:'))">											
							<td align="center">
								<xsl:if test="//n1:Invoice/cbc:Note[contains(.,'Toplam Kap')]">
									<span id="totalTable">
										<xsl:value-of select="substring-after(//n1:Invoice/cbc:Note[contains(.,'Toplam Kap    :')],':')" />
									</span>
								</xsl:if>
							</td>		
							<td align="center">
								<xsl:if test="//n1:Invoice/cbc:Note[contains(.,'Toplam Darali')]">
									<span id="totalTable">
										<xsl:value-of select="substring-after(//n1:Invoice/cbc:Note[contains(.,'Toplam Darali :')],':')" />
									</span>
								</xsl:if>
							</td>
							<td align="center">
								<xsl:if test="//n1:Invoice/cbc:Note[contains(.,'Toplam Dara')]">
									<span id="totalTable">
										<xsl:value-of select="substring-after(//n1:Invoice/cbc:Note[contains(.,'Toplam Dara   :')],':')" />
									</span>
								</xsl:if>
							</td>	
						</xsl:if>
                        
						<td align="center">
							<xsl:if test="//n1:Invoice/cbc:Note[contains(.,'Toplam Miktar')]">
								<span id="totalTable">
									<xsl:value-of select="substring-after(//n1:Invoice/cbc:Note[contains(.,'Toplam Miktar :')],':')" />
								</span>
							</xsl:if>	
						</td>
                        <td> </td>
                        <td> </td>
                        <td> </td>
                        <td> </td>
                        <td> </td>
                        <td> </td>
                        <td> </td>
                      </tr>
              </table>
            </td>
          </tr>
          <xsl:if test="$index = $count">
            <tr class="containerTr">
              <td id="invoiceTotal">
                <table align="right" id="budgetContainerTable">
                  <tr>
                    <th>Mal Hizmet Toplam Tutarı</th>
                    <td>
                      <xsl:value-of select="format-number(n1:Invoice/cac:LegalMonetaryTotal/cbc:LineExtensionAmount, '###.##0,00', 'european')"/>
                      <xsl:if test="n1:Invoice/cac:LegalMonetaryTotal/cbc:LineExtensionAmount/@currencyID">
                        <xsl:if test="n1:Invoice/cac:LegalMonetaryTotal/cbc:LineExtensionAmount/@currencyID = 'TRY'">
                          <xsl:text>&#160; TL</xsl:text>
                        </xsl:if>
                        <xsl:if test="n1:Invoice/cac:LegalMonetaryTotal/cbc:LineExtensionAmount/@currencyID != 'TRY'">
                          <xsl:value-of select="n1:Invoice/cac:LegalMonetaryTotal/cbc:LineExtensionAmount/@currencyID"/>
                        </xsl:if>
                      </xsl:if>
                    </td>
                  </tr>
                  <xsl:if test="$legalMonetary >0 or $linediscount >0 ">
                    <tr>
                      <th>Toplam İskonto</th>
                      <td>
                        <xsl:value-of select="format-number(($legalMonetary + $linediscount), '###.##0,00', 'european')"/>
                        <xsl:if test="n1:Invoice/cac:LegalMonetaryTotal/cbc:AllowanceTotalAmount/@currencyID">
                          <xsl:if test="n1:Invoice/cac:LegalMonetaryTotal/cbc:AllowanceTotalAmount/@currencyID = 'TRY'">
                                                        <xsl:text>&#160; TL</xsl:text>
                                                    </xsl:if>
                                                    <xsl:if test="n1:Invoice/cac:LegalMonetaryTotal/cbc:AllowanceTotalAmount/@currencyID != 'TRY'">
                                                        <xsl:value-of select="n1:Invoice/cac:LegalMonetaryTotal/cbc:AllowanceTotalAmount/@currencyID"/>
                                                    </xsl:if>
                                                </xsl:if>
                                            </td>
                                        </tr>
                                    </xsl:if>
                  <tr>
                    <th>Net Toplam</th>
                    <td>
                      <xsl:value-of select="format-number(n1:Invoice/cac:LegalMonetaryTotal/cbc:TaxExclusiveAmount, '###.##0,00', 'european')"/>
                      <xsl:if test="n1:Invoice/cac:LegalMonetaryTotal/cbc:TaxExclusiveAmount/@currencyID">
                        <xsl:if test="n1:Invoice/cac:LegalMonetaryTotal/cbc:TaxExclusiveAmount/@currencyID = 'TRY'">
                          <xsl:text>&#160;TL</xsl:text>
                        </xsl:if>
                        <xsl:if test="n1:Invoice/cac:LegalMonetaryTotal/cbc:TaxExclusiveAmount/@currencyID != 'TRY'">
                          <xsl:value-of select="n1:Invoice/cac:LegalMonetaryTotal/cbc:TaxExclusiveAmount/@currencyID"/>
                        </xsl:if>
                      </xsl:if>
                    </td>
                  </tr>
                                    <xsl:for-each select="//n1:Invoice/cac:TaxTotal/cac:TaxSubtotal">
                                        <xsl:sort select="cbc:Percent" data-type="number"/>
                                        <tr>
                                            <th>
                                                <xsl:value-of select="cac:TaxCategory/cac:TaxScheme/cbc:Name"/>&#160;%<xsl:value-of select="cbc:Percent"/>&#160;(Matrah: <xsl:value-of select="format-number(cbc:TaxableAmount, '###.##0,00', 'european')"/>)
                      </th>
                                            <td>
                                                <xsl:value-of select="format-number(cbc:TaxAmount, '###.##0,00', 'european')"/>
                                            </td>
                                        </tr>
                                    </xsl:for-each>
                                    <tr>
                                        <th>
                                            <xsl:choose>
                                                <xsl:when test="count(n1:Invoice/cac:TaxTotal/cac:TaxSubtotal/cac:TaxCategory/cac:TaxScheme[TaxTypeCode='9015'])>0">
                                                    <xsl:text>Tevkifat </xsl:text>
                                                </xsl:when>
                                                <xsl:otherwise>
                                                    <xsl:text>Vergiler </xsl:text>
                                                </xsl:otherwise>
                                            </xsl:choose>
                                            <xsl:text>Dahil Toplam Tutar</xsl:text>
                                        </th>
                                        <td>
                                            <xsl:value-of select="format-number(n1:Invoice/cac:LegalMonetaryTotal/cbc:TaxInclusiveAmount, '###.##0,00', 'european')"/>
                                            <xsl:if test="n1:Invoice/cac:LegalMonetaryTotal/cbc:TaxInclusiveAmount/@currencyID">
                                                <xsl:if test="n1:Invoice/cac:LegalMonetaryTotal/cbc:TaxInclusiveAmount/@currencyID = 'TRY'">
                                                    <xsl:text>&#160; TL</xsl:text>
                                                </xsl:if>
                                                <xsl:if test="n1:Invoice/cac:LegalMonetaryTotal/cbc:TaxInclusiveAmount/@currencyID != 'TRY'">
                                                    <xsl:value-of select="n1:Invoice/cac:LegalMonetaryTotal/cbc:TaxInclusiveAmount/@currencyID"/>
                                                </xsl:if>
                                            </xsl:if>
                                        </td>
                                    </tr>
                                    <tr>
                                        <th>Ödenecek Tutar</th>
                                        <td>
                                            <xsl:value-of select="format-number(n1:Invoice/cac:LegalMonetaryTotal/cbc:PayableAmount, '###.##0,00', 'european')"/>
                                            <xsl:if test="n1:Invoice/cac:LegalMonetaryTotal/cbc:PayableAmount/@currencyID">
                                                <xsl:if test="n1:Invoice/cac:LegalMonetaryTotal/cbc:PayableAmount/@currencyID = 'TRY'">
                                                    <xsl:text>&#160; TL</xsl:text>
                                                </xsl:if>
                                                <xsl:if test="n1:Invoice/cac:LegalMonetaryTotal/cbc:PayableAmount/@currencyID != 'TRY'">
                                                    <xsl:value-of select="n1:Invoice/cac:LegalMonetaryTotal/cbc:PayableAmount/@currencyID"/>
                                                </xsl:if>
                                            </xsl:if>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
            <tr class="notesMainTr">
              <td id="notes">
                <table id="notesTable">
                     <xsl:for-each select="$footerNote">
<!--                       
					   <tr>
                          <td class="capital">
                                <pre align="left">
                                <xsl:value-of select="."/>
                                </pre>
                            </td>
                        </tr>
-->
						<tr>
						 <td class="capital">
							<xsl:if test="not(contains(.,'Net Yekün')) and 
										  not(contains(.,'İadeli Kap')) and
										  not(contains(.,'Toplam Kap    :')) and 	
										  not(contains(.,'Toplam Dara   :')) and 											  
										  not(contains(.,'Toplam Darali :')) and										  
										  not(contains(.,'Toplam Miktar :')) and
										  not(contains(.,'Marka :')) and
										  not(contains(.,'Stok Giriş Tarihi'))">
								<pre align="left">
									<xsl:value-of select="." />
								</pre>
							</xsl:if>
							</td>
						</tr>
                    </xsl:for-each>
                  <xsl:if test="//n1:Invoice/cac:PaymentMeans/cac:PayeeFinancialAccount/cbc:PaymentNote">
                    <tr>
                      <td class="noteLbl">Ödeme Açıklaması</td>
                      <td>:</td>
                      <td>
                        <xsl:value-of select="//n1:Invoice/cac:PaymentMeans/cac:PayeeFinancialAccount/cbc:PaymentNote"/>
                        <xsl:text>IBAN:&#160;</xsl:text>
                        <xsl:value-of select="//n1:Invoice/cac:PaymentMeans/cac:PayeeFinancialAccount/cbc:ID"/>
                      </td>
                    </tr>
                  </xsl:if>
                  <xsl:for-each select="//n1:Invoice/cac:TaxTotal/cac:TaxSubtotal">
                    <xsl:if test="cbc:Percent=0 and cac:TaxCategory/cac:TaxScheme/cbc:TaxTypeCode=&apos;0015&apos;">
                      <b>
                        &#160;&#160;&#160;&#160;&#160; Vergi
                        İstisna Muafiyet Sebebi:
                      </b>
                      <xsl:value-of select="cac:TaxCategory/cbc:TaxExemptionReason"/>
                      <br/>
                    </xsl:if>
                  </xsl:for-each>
                <xsl:if test="//n1:Invoice/cbc:Note[contains(.,'FOOTER2')]">
                    <tr>
                        <td class="noteLbl">Yazı İle :</td>
                        <td class="capital">
                            <span>
                                <xsl:value-of select="substring(//n1:Invoice/cbc:Note[contains(.,'FOOTER2')],10,1000)"/>
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
                          <xsl:value-of select="substring-after(//n1:Invoice/cbc:Note[contains(.,'PLAKA')],']')"/>
                        </span>
                      </td>
                    </tr>
                  </xsl:if>
                  <xsl:if test="//n1:Invoice/cac:PaymentTerms/cbc:Note">
                    <tr>
                      <td class="noteLbl">Ödeme Koşulu</td>
                      <td>:</td>
                      <td class="capital">
                        <xsl:value-of select="//n1:Invoice/cac:PaymentTerms/cbc:Note"/>
                      </td>
                    </tr>
                  </xsl:if>
                  <xsl:for-each select="//n1:Invoice/cac:AdditionalDocumentReference">
                    <xsl:if test="cbc:DocumentType[contains(.,'FATURAKODLIST')]">
                      <tr>
                        <!--<span class="noteLbl">Fatura Kod List : </span>
                        <xsl:value-of select="cbc:ID"/>-->
                        <td class="noteLbl">Fatura Kod List : </td>
                        <td class="capital">
                          <xsl:value-of select="cbc:ID"/>
                        </td>
                      </tr>
                    </xsl:if>
                  </xsl:for-each>
                  <xsl:if test="//n1:Invoice/cbc:Note[contains(.,'VAR')]">
                    <tr>
                      <td class="noteLbl">KÜNYE : </td>
                      <td class="capital">
                        <xsl:value-of select="//n1:Invoice/cbc:Note[contains(.,'VAR')]"/>
                      </td>
                    </tr>
                  </xsl:if>
                  
                  <!--
                  <xsl:if test="//n1:Invoice/cac:PaymentMeans"'>
                    <tr>
                      <td class="noteLbl">Ödeme Şekli</td>
                      <td>:</td>
                      <td>
                        <xsl:for-each select="//n1:Invoice/cac:PaymentMeans">
                          <xsl:choose>
                            <xsl:when test="./cbc:PaymentMeansCode[.=48]">
                              <span>
                                Faturanın&#160;<xsl:value-of select="./cbc:InstructionNote"/>&#160;TL'si kredi kartı kullanılarak tahsil edilmiştir.
                              </span>
                            </xsl:when>
                          </xsl:choose>
                          <xsl:choose>
                            <xsl:when test="./cbc:PaymentMeansCode[.=30]">
                              <span>
                                Faturanın&#160;<xsl:value-of select="./cbc:InstructionNote"/>&#160;TL'sinin&#160;vadesi&#160;
                              </span>
                              <xsl:value-of select="substring(./cbc:PaymentDueDate,9,2)"/>.<xsl:value-of select="substring(./cbc:PaymentDueDate,6,2)"/>.<xsl:value-of select="substring(./cbc:PaymentDueDate,1,4)"/>
                              <span>&#160;tarihine kadardır.</span>
                            </xsl:when>
                          </xsl:choose>
                          <xsl:choose>
                            <xsl:when test="./cbc:PaymentMeansCode[.=10]">
                              <span>
                                Peşin
                              </span>
                            </xsl:when>
                          </xsl:choose>
                          <br/>
                        </xsl:for-each>
                      </td>
                    </tr>
                  </xsl:if>
-->
                  <!--
                  <xsl:if test="n1:Invoice/cac:AdditionalDocumentReference/cbc:ID != '' ">
                    <tr>
                      <td class="noteLbl">Referans No</td>
                      <td>:</td>
                      <td class="capital">
                        <xsl:value-of select="n1:Invoice/cac:AdditionalDocumentReference/cbc:ID"/>
                      </td>
                    </tr>
                  </xsl:if>
-->
                
                <xsl:if test="count(//n1:Invoice/cac:DespatchDocumentReference)=0">
                    <tr>
                      <td class="capital">
                        <span style="font-weight:bold;color:blue;">
                            <xsl:text>İrsaliye yerine geçer.</xsl:text>
                        </span>
                      </td>
                    </tr>
                </xsl:if>
                </table>
              </td>
            </tr>
          </xsl:if>
          <tr class="pageInfo">
            <td style="font-size: 12px;" align="center">
              Sayfa: <xsl:value-of select="$index"/> / <xsl:value-of select="$count"/>
            </td>
          </tr>
        </table>
      </xsl:for-each>
      <xsl:call-template name="Paging">
        <xsl:with-param name="index" select="$index + 1"/>
        <xsl:with-param name="count" select="$count"/>
            </xsl:call-template>
        </xsl:if>
    </xsl:template>
</xsl:stylesheet>
