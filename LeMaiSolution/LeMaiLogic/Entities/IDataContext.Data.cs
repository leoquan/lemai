using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace LeMaiLogic
{
	public partial interface IDataContext
	{
		IACcountobject ACcountobject { get; }

		IACcountobjectandgroup ACcountobjectandgroup { get; }

		IACcountobjectbranch ACcountobjectbranch { get; }

		IACcountobjectcommission ACcountobjectcommission { get; }

		IACcountobjectgroup ACcountobjectgroup { get; }

		IACcountobjectimage ACcountobjectimage { get; }

		IACcountobjectrewardpoint ACcountobjectrewardpoint { get; }

		IACcountobjecttype ACcountobjecttype { get; }

		IBOoking BOoking { get; }

		IBOokingdetail BOokingdetail { get; }

		IBRanch BRanch { get; }

		ICAshpay CAshpay { get; }

		ICAshpaymoneytype CAshpaymoneytype { get; }

		ICAshpaytype CAshpaytype { get; }

		ICOnfigbookingtime COnfigbookingtime { get; }

		ICOntacthistory COntacthistory { get; }

		IDYnamicfield DYnamicfield { get; }

		IDYnamicfieldtype DYnamicfieldtype { get; }

		IDYnamicfilledformfields DYnamicfilledformfields { get; }

		IDYnamicfilledforms DYnamicfilledforms { get; }

		IDYnamicform DYnamicform { get; }

		IDYnamicformfield DYnamicformfield { get; }

		IEXpaccountcustomer EXpaccountcustomer { get; }

		IEXpautoreport EXpautoreport { get; }

		IEXpbalancedetail EXpbalancedetail { get; }

		IEXpbalancedetailtype EXpbalancedetailtype { get; }

		IEXpbill EXpbill { get; }

		IEXpbillprocess EXpbillprocess { get; }

		IEXpbillstatus EXpbillstatus { get; }

		IEXpcachgiao EXpcachgiao { get; }

		IEXpcachthanhtoan EXpcachthanhtoan { get; }

		IEXpcalamviec EXpcalamviec { get; }

		IEXpcaresale EXpcaresale { get; }

		IEXpcaresalehistory EXpcaresalehistory { get; }

		IEXpcashpay EXpcashpay { get; }

		IEXpcheckbalance EXpcheckbalance { get; }

		IEXpcheckbalancedetail EXpcheckbalancedetail { get; }

		IEXpchungtu EXpchungtu { get; }

		IEXpchungtuct EXpchungtuct { get; }

		IEXpcodck EXpcodck { get; }

		IEXpcomment EXpcomment { get; }

		IEXpcommenttype EXpcommenttype { get; }

		IEXpcomplainservice EXpcomplainservice { get; }

		IEXpconsigndelivery EXpconsigndelivery { get; }

		IEXpconsignment EXpconsignment { get; }

		IEXpconsignmentcashpay EXpconsignmentcashpay { get; }

		IEXpconsignmentcashpaytype EXpconsignmentcashpaytype { get; }

		IEXpconsignmenthistory EXpconsignmenthistory { get; }

		IEXpconsignmentobject EXpconsignmentobject { get; }

		IEXpconsignmentondelivery EXpconsignmentondelivery { get; }

		IEXpconsignmentqueuenumber EXpconsignmentqueuenumber { get; }

		IEXpconsignmentstatus EXpconsignmentstatus { get; }

		IEXpconsigntransit EXpconsigntransit { get; }

		IEXpcontact EXpcontact { get; }

		IEXpcontentmessage EXpcontentmessage { get; }

		IEXpcost EXpcost { get; }

		IEXpcustomer EXpcustomer { get; }

		IEXpcustomeraccount EXpcustomeraccount { get; }

		IEXpcustomergroup EXpcustomergroup { get; }

		IEXpdestination EXpdestination { get; }

		IEXpdistance EXpdistance { get; }

		IEXpdoisoat EXpdoisoat { get; }

		IEXpdoisoatchitiet EXpdoisoatchitiet { get; }

		IEXpdoisoatchitietct EXpdoisoatchitietct { get; }

		IEXpdonvihanhchinh EXpdonvihanhchinh { get; }

		IEXpfee EXpfee { get; }

		IEXpgroupfee EXpgroupfee { get; }

		IEXphoadondoisoat EXphoadondoisoat { get; }

		IEXphoadondoisoatkl EXphoadondoisoatkl { get; }

		IEXpinternal EXpinternal { get; }

		IEXpkykettoan EXpkykettoan { get; }

		IEXploaimathang EXploaimathang { get; }

		IEXploancod EXploancod { get; }

		IEXplogerrorcheck EXplogerrorcheck { get; }

		IEXploinhuanbuucuc EXploinhuanbuucuc { get; }

		IEXpmistake EXpmistake { get; }

		IEXpnhapkho EXpnhapkho { get; }

		IEXpnhapkhoct EXpnhapkhoct { get; }

		IEXpnote EXpnote { get; }

		IEXpphathanhchungtu EXpphathanhchungtu { get; }

		IEXppost EXppost { get; }

		IEXppostaccount EXppostaccount { get; }

		IEXppostfeeprovider EXppostfeeprovider { get; }

		IEXpproblem EXpproblem { get; }

		IEXpproviceproblem EXpproviceproblem { get; }

		IEXpprovider EXpprovider { get; }

		IEXpprovincefee EXpprovincefee { get; }

		IEXpprovincefeecustomer EXpprovincefeecustomer { get; }

		IEXprecharge EXprecharge { get; }

		IEXprecheck EXprecheck { get; }

		IEXpsalecongno EXpsalecongno { get; }

		IEXpsaleloaithanhtoan EXpsaleloaithanhtoan { get; }

		IEXpsalenhapvattu EXpsalenhapvattu { get; }

		IEXpsaleproduct EXpsaleproduct { get; }

		IEXpsalevattu EXpsalevattu { get; }

		IEXpsalexuatkho EXpsalexuatkho { get; }

		IEXpscan EXpscan { get; }

		IEXpscantt EXpscantt { get; }

		IEXpshipper EXpshipper { get; }

		IEXpsiteautorun EXpsiteautorun { get; }

		IEXptype EXptype { get; }

		IEXpwithdrawal EXpwithdrawal { get; }

		IEXpwithdrawrequest EXpwithdrawrequest { get; }

		IEXpwithdrawrequeststatus EXpwithdrawrequeststatus { get; }

		IEXpwithdrawrequesttype EXpwithdrawrequesttype { get; }

		IGExpaccept GExpaccept { get; }

		IGExpautosign GExpautosign { get; }

		IGExpbalancedetail GExpbalancedetail { get; }

		IGExpbalancedetailpost GExpbalancedetailpost { get; }

		IGExpbalancedetailtype GExpbalancedetailtype { get; }

		IGExpbankemail GExpbankemail { get; }

		IGExpbankvp GExpbankvp { get; }

		IGExpbill GExpbill { get; }

		IGExpbillhistory GExpbillhistory { get; }

		IGExpbillstatus GExpbillstatus { get; }

		IGExpbillstatusname GExpbillstatusname { get; }

		IGExpcode GExpcode { get; }

		IGExpdebitcomparison GExpdebitcomparison { get; }

		IGExpdebitcomparisondetail GExpdebitcomparisondetail { get; }

		IGExpdistrict GExpdistrict { get; }

		IGExpdistrictghsv GExpdistrictghsv { get; }

		IGExpdistrictjnt GExpdistrictjnt { get; }

		IGExpdistrictvn GExpdistrictvn { get; }

		IGExpdistrictvnp GExpdistrictvnp { get; }

		IGExpdistrictvtp GExpdistrictvtp { get; }

		IGExpdoisoat GExpdoisoat { get; }

		IGExpdoisoatchitiet GExpdoisoatchitiet { get; }

		IGExpdoisoatchitietct GExpdoisoatchitietct { get; }

		IGExpdoisoathistory GExpdoisoathistory { get; }

		IGExperror GExperror { get; }

		IGExpfee GExpfee { get; }

		IGExpfeedetail GExpfeedetail { get; }

		IGExpfeeprovincedetail GExpfeeprovincedetail { get; }

		IGExpmoneyreturn GExpmoneyreturn { get; }

		IGExpmoneyreturnsession GExpmoneyreturnsession { get; }

		IGExpmoneyreturnstatus GExpmoneyreturnstatus { get; }

		IGExpnotification GExpnotification { get; }

		IGExporder GExporder { get; }

		IGExporderstatus GExporderstatus { get; }

		IGExppaymenttype GExppaymenttype { get; }

		IGExpproblem GExpproblem { get; }

		IGExpprofit GExpprofit { get; }

		IGExpprovider GExpprovider { get; }

		IGExpproviderconfig GExpproviderconfig { get; }

		IGExpprovidercustomer GExpprovidercustomer { get; }

		IGExpprovidersub GExpprovidersub { get; }

		IGExpprovidertype GExpprovidertype { get; }

		IGExpprovince GExpprovince { get; }

		IGExpprovincefeez GExpprovincefeez { get; }

		IGExpprovinceghsv GExpprovinceghsv { get; }

		IGExpprovincejnt GExpprovincejnt { get; }

		IGExpprovincevn GExpprovincevn { get; }

		IGExpprovincevnp GExpprovincevnp { get; }

		IGExpprovincevtp GExpprovincevtp { get; }

		IGExpreceivetask GExpreceivetask { get; }

		IGExpreceivetaskstatus GExpreceivetaskstatus { get; }

		IGExprequestmoney GExprequestmoney { get; }

		IGExpscan GExpscan { get; }

		IGExpscancome GExpscancome { get; }

		IGExpscandelivery GExpscandelivery { get; }

		IGExpscanreceive GExpscanreceive { get; }

		IGExpscanreturn GExpscanreturn { get; }

		IGExpscansend GExpscansend { get; }

		IGExpscansign GExpscansign { get; }

		IGExpscantype GExpscantype { get; }

		IGExpsender GExpsender { get; }

		IGExpshipnotetype GExpshipnotetype { get; }

		IGExpshipper GExpshipper { get; }

		IGExpshipperbillstatus GExpshipperbillstatus { get; }

		IGExpshippercash GExpshippercash { get; }

		IGExpshippercashdetail GExpshippercashdetail { get; }

		IGExpshipperdevivery GExpshipperdevivery { get; }

		IGExpward GExpward { get; }

		IGExpwardghsv GExpwardghsv { get; }

		IGExpwardjnt GExpwardjnt { get; }

		IGExpwardvn GExpwardvn { get; }

		IGExpwardvnp GExpwardvnp { get; }

		IGExpwardvtp GExpwardvtp { get; }

		IGExpwebhook GExpwebhook { get; }

		IGExpwithdrawmoney GExpwithdrawmoney { get; }

		IGSbank GSbank { get; }

		IGScategory GScategory { get; }

		IGSccy GSccy { get; }

		IGScountry GScountry { get; }

		IGScustomeroder GScustomeroder { get; }

		IGSkpiaccounttarget GSkpiaccounttarget { get; }

		IGSkpiaccounttargetruntime GSkpiaccounttargetruntime { get; }

		IGSkpitarget GSkpitarget { get; }

		IGSkpitargettype GSkpitargettype { get; }

		IGSport GSport { get; }

		IGSrequestfindproduct GSrequestfindproduct { get; }

		IGSrequestfindproducthistory GSrequestfindproducthistory { get; }

		IGSrequestinstance GSrequestinstance { get; }

		IGSstepdef GSstepdef { get; }

		IGSsteprequestfindproduct GSsteprequestfindproduct { get; }

		IGSunit GSunit { get; }

		IGSworkflowdef GSworkflowdef { get; }

		IINventory INventory { get; }

		IINvoice INvoice { get; }

		IINvoicedetail INvoicedetail { get; }

		IMAmnonclass MAmnonclass { get; }

		IMAmnonclasshocvien MAmnonclasshocvien { get; }

		IMAmnondiemdanh MAmnondiemdanh { get; }

		IMAmnonhocvien MAmnonhocvien { get; }

		IMAmnonsodaubai MAmnonsodaubai { get; }

		IMAmnonthangdiem MAmnonthangdiem { get; }

		IMAmnonthuhocphi MAmnonthuhocphi { get; }

		IMAmnontruonghoc MAmnontruonghoc { get; }

		IMEdbacsicdha MEdbacsicdha { get; }

		IMEdbenhnhan MEdbenhnhan { get; }

		IMEdcapmaso MEdcapmaso { get; }

		IMEdchidinh MEdchidinh { get; }

		IMEdchidinhsync MEdchidinhsync { get; }

		IMEdcoso MEdcoso { get; }

		IMEdcotbaocao MEdcotbaocao { get; }

		IMEddmdonvi MEddmdonvi { get; }

		IMEddmketqua MEddmketqua { get; }

		IMEddmmay MEddmmay { get; }

		IMEddmso MEddmso { get; }

		IMEddmten MEddmten { get; }

		IMEdgiavp MEdgiavp { get; }

		IMEdhistory MEdhistory { get; }

		IMEdhistoryct MEdhistoryct { get; }

		IMEdhosonhanbenh MEdhosonhanbenh { get; }

		IMEdketluanmau MEdketluanmau { get; }

		IMEdketqua MEdketqua { get; }

		IMEdketquaautotext MEdketquaautotext { get; }

		IMEdketquachandoan MEdketquachandoan { get; }

		IMEdketquachandoanha MEdketquachandoanha { get; }

		IMEdketquact MEdketquact { get; }

		IMEdketquadcm MEdketquadcm { get; }

		IMEdketquaecg MEdketquaecg { get; }

		IMEdketquamacdinh MEdketquamacdinh { get; }

		IMEdketquamayxn MEdketquamayxn { get; }

		IMEdketquaxn MEdketquaxn { get; }

		IMEdkhoaphong MEdkhoaphong { get; }

		IMEdlaymau MEdlaymau { get; }

		IMEdlaymauct MEdlaymauct { get; }

		IMEdloaikhoaphong MEdloaikhoaphong { get; }

		IMEdloaivp MEdloaivp { get; }

		IMEdlogin MEdlogin { get; }

		IMEdmaso MEdmaso { get; }

		IMEdmauin MEdmauin { get; }

		IMEdmauketqua MEdmauketqua { get; }

		IMEdmayxn MEdmayxn { get; }

		IMEdnhombenhnhan MEdnhombenhnhan { get; }

		IMEdnhomvp MEdnhomvp { get; }

		IMEdphieunhanbenh MEdphieunhanbenh { get; }

		IMEdphieunhanbenhchitiet MEdphieunhanbenhchitiet { get; }

		IMEdserver MEdserver { get; }

		IMEdsetting MEdsetting { get; }

		IMEdsomauxetnghiem MEdsomauxetnghiem { get; }

		IMEdthongsokqmayxn MEdthongsokqmayxn { get; }

		IMEdticcapmaso MEdticcapmaso { get; }

		IMEdworkspace MEdworkspace { get; }

		IMEdxnloai MEdxnloai { get; }

		IMEdxnloaimay MEdxnloaimay { get; }

		IMEdxnten MEdxnten { get; }

		IMEdxnthongsomay MEdxnthongsomay { get; }

		IMEdxnthongsomayct MEdxnthongsomayct { get; }

		IMEnufunction MEnufunction { get; }

		IMEnufunctionaccount MEnufunctionaccount { get; }

		IMEnufunctionrole MEnufunctionrole { get; }

		IMEnufunctiongroup MEnufunctiongroup { get; }

		IMEnuimage MEnuimage { get; }

		IMEnurole MEnurole { get; }

		IMEnuroleaccountobject MEnuroleaccountobject { get; }

		IPRoductquota PRoductquota { get; }

		IQUeuenumber QUeuenumber { get; }

		IROom ROom { get; }

		IROomgroup ROomgroup { get; }

		ISAlebalancedetail SAlebalancedetail { get; }

		ISAlebanggia SAlebanggia { get; }

		ISAlebanggiachitiet SAlebanggiachitiet { get; }

		ISAlehoadon SAlehoadon { get; }

		ISAlehoadonchitiet SAlehoadonchitiet { get; }

		ISAlekhachhang SAlekhachhang { get; }

		ISAlenhomsanpham SAlenhomsanpham { get; }

		ISAlesanpham SAlesanpham { get; }

		ISChoolcapbac SChoolcapbac { get; }

		ISChoolgiaotrinh SChoolgiaotrinh { get; }

		ISChoolgiaotrinhhocphan SChoolgiaotrinhhocphan { get; }

		ISChoolhocphan SChoolhocphan { get; }

		ISChoolhocvien SChoolhocvien { get; }

		ISChoolphonggiaoduc SChoolphonggiaoduc { get; }

		ISChoolprogram SChoolprogram { get; }

		ISChoolroom SChoolroom { get; }

		ISChoolsogiaoduc SChoolsogiaoduc { get; }

		ISChooltrungtamav SChooltrungtamav { get; }

		ISErvice SErvice { get; }

		ISErvicecombo SErvicecombo { get; }

		ISErvicegroup SErvicegroup { get; }

		ISErviceimage SErviceimage { get; }

		ISEtting SEtting { get; }

		ISEttingbranch SEttingbranch { get; }

		ISTock STock { get; }

		ISTockimportexport STockimportexport { get; }

		ISTockimportexportdetail STockimportexportdetail { get; }

		ISYsdiagrams SYsdiagrams { get; }

		ITAskactionhistory TAskactionhistory { get; }

		ITAskissue TAskissue { get; }

		ITAskissuepriority TAskissuepriority { get; }

		ITAskissuestatus TAskissuestatus { get; }

		ITAskissuetracker TAskissuetracker { get; }

		IVCkettoan VCkettoan { get; }

		IVCkhachhang VCkhachhang { get; }

		IVCloaichiphi VCloaichiphi { get; }

		IVCmathang VCmathang { get; }

		IVCnhacungcap VCnhacungcap { get; }

		IVCnhaphang VCnhaphang { get; }

		IVCxuathang VCxuathang { get; }

		IVIewaccountobject VIewaccountobject { get; }

		IVIewautosigndelivery VIewautosigndelivery { get; }

		IVIewbaocaotaichinh VIewbaocaotaichinh { get; }

		IVIewbooking VIewbooking { get; }

		IVIewbranch VIewbranch { get; }

		IVIewcashpay VIewcashpay { get; }

		IVIewdoisoatchitiet VIewdoisoatchitiet { get; }

		IVIewexpbill VIewexpbill { get; }

		IVIewexpbillhoadondoisoat VIewexpbillhoadondoisoat { get; }

		IVIewexpcashpay VIewexpcashpay { get; }

		IVIewexpchungtu VIewexpchungtu { get; }

		IVIewexpchungtuct VIewexpchungtuct { get; }

		IVIewexpchungtuctreport VIewexpchungtuctreport { get; }

		IVIewexpchungtuphieuchi VIewexpchungtuphieuchi { get; }

		IVIewexpcodck VIewexpcodck { get; }

		IVIewexpcomment VIewexpcomment { get; }

		IVIewexpconsigndelivery VIewexpconsigndelivery { get; }

		IVIewexpconsignment VIewexpconsignment { get; }

		IVIewexpconsignmentcashpay VIewexpconsignmentcashpay { get; }

		IVIewexpconsignmenthistory VIewexpconsignmenthistory { get; }

		IVIewexpconsignmenthistorymater VIewexpconsignmenthistorymater { get; }

		IVIewexpconsignmentobject VIewexpconsignmentobject { get; }

		IVIewexpconsigntransit VIewexpconsigntransit { get; }

		IVIewexpcustomer VIewexpcustomer { get; }

		IVIewexpcustomergroup VIewexpcustomergroup { get; }

		IVIewexpdvhchuyen VIewexpdvhchuyen { get; }

		IVIewexpdvhctinh VIewexpdvhctinh { get; }

		IVIewexpdvhcxa VIewexpdvhcxa { get; }

		IVIewexpkykettoan VIewexpkykettoan { get; }

		IVIewexploancod VIewexploancod { get; }

		IVIewexpnhapkho VIewexpnhapkho { get; }

		IVIewexpnhapkhoct VIewexpnhapkhoct { get; }

		IVIewexppost VIewexppost { get; }

		IVIewexpproviceproblem VIewexpproviceproblem { get; }

		IVIewexprecharge VIewexprecharge { get; }

		IVIewexpsalenhapvattu VIewexpsalenhapvattu { get; }

		IVIewexpsalexuatkho VIewexpsalexuatkho { get; }

		IVIewexptotalchungtu VIewexptotalchungtu { get; }

		IVIewexpwithdrawrequest VIewexpwithdrawrequest { get; }

		IVIewgexpautosign VIewgexpautosign { get; }

		IVIewgexpbalancedetail VIewgexpbalancedetail { get; }

		IVIewgexpbalancedetailpost VIewgexpbalancedetailpost { get; }

		IVIewgexpbill VIewgexpbill { get; }

		IVIewgexpbillcus VIewgexpbillcus { get; }

		IVIewgexpbilldelivery VIewgexpbilldelivery { get; }

		IVIewgexpbillghn VIewgexpbillghn { get; }

		IVIewgexpbillghnapi VIewgexpbillghnapi { get; }

		IVIewgexpbillhistory VIewgexpbillhistory { get; }

		IVIewgexpdebitcomparison VIewgexpdebitcomparison { get; }

		IVIewgexpdebitcomparisondetail VIewgexpdebitcomparisondetail { get; }

		IVIewgexpdoisoatchitiet VIewgexpdoisoatchitiet { get; }

		IVIewgexpfee VIewgexpfee { get; }

		IVIewgexpfeedetails VIewgexpfeedetails { get; }

		IVIewgexpfeedetailspro VIewgexpfeedetailspro { get; }

		IVIewgexpmoneyreturn VIewgexpmoneyreturn { get; }

		IVIewgexpmoneyreturnsession VIewgexpmoneyreturnsession { get; }

		IVIewgexpnotification VIewgexpnotification { get; }

		IVIewgexporder VIewgexporder { get; }

		IVIewgexpproblem VIewgexpproblem { get; }

		IVIewgexpprovider VIewgexpprovider { get; }

		IVIewgexpreceivetask VIewgexpreceivetask { get; }

		IVIewgexprequestmoney VIewgexprequestmoney { get; }

		IVIewgexpscan VIewgexpscan { get; }

		IVIewgexpscancome VIewgexpscancome { get; }

		IVIewgexpscandelivery VIewgexpscandelivery { get; }

		IVIewgexpscanreturn VIewgexpscanreturn { get; }

		IVIewgexpscansend VIewgexpscansend { get; }

		IVIewgexpscansign VIewgexpscansign { get; }

		IVIewgexpshipper VIewgexpshipper { get; }

		IVIewgexpshippercash VIewgexpshippercash { get; }

		IVIewgexpshippercashdetail VIewgexpshippercashdetail { get; }

		IVIewgexpshipperdevivery VIewgexpshipperdevivery { get; }

		IVIewgexpwithdrawmoney VIewgexpwithdrawmoney { get; }

		IVIewinvoicelist VIewinvoicelist { get; }

		IVIewinvoiceprint VIewinvoiceprint { get; }

		IVIewmamnontruonghoc VIewmamnontruonghoc { get; }

		IVIewmenufunction VIewmenufunction { get; }

		IVIewmenufunctionaccount VIewmenufunctionaccount { get; }

		IVIewrole VIewrole { get; }

		IVIewroom VIewroom { get; }

		IVIewroomgroup VIewroomgroup { get; }

		IVIewschoolgiaotrinh VIewschoolgiaotrinh { get; }

		IVIewschoolgiaotrinhhocphan VIewschoolgiaotrinhhocphan { get; }

		IVIewschoolhocphan VIewschoolhocphan { get; }

		IVIewschoolphonggiaoduc VIewschoolphonggiaoduc { get; }

		IVIewschoolprogram VIewschoolprogram { get; }

		IVIewschoolroom VIewschoolroom { get; }

		IVIewschoolsogiaoduc VIewschoolsogiaoduc { get; }

		IVIewschooltrungtamav VIewschooltrungtamav { get; }

		IVIewservice VIewservice { get; }

		IVIewservicegroup VIewservicegroup { get; }

		IVIewsubmenugroup VIewsubmenugroup { get; }

		IVIewsumgexpbill VIewsumgexpbill { get; }

		IVIewsumgexpbillkynhan VIewsumgexpbillkynhan { get; }

		IVIewsumgexpbillsanluong VIewsumgexpbillsanluong { get; }

		IVIewsumgexpbillstatus VIewsumgexpbillstatus { get; }

		IVIewvckettoan VIewvckettoan { get; }

		IVIewvckhachhang VIewvckhachhang { get; }

		IVIewvcmathang VIewvcmathang { get; }

		IVIewvcnhacungcap VIewvcnhacungcap { get; }

		IVIewvihclecoupon VIewvihclecoupon { get; }

		IVIewvihclecoupondetail VIewvihclecoupondetail { get; }

		IVIewwebbannerslider VIewwebbannerslider { get; }

		IVIewwebnews VIewwebnews { get; }

		IVIewwebpage VIewwebpage { get; }

		IVIhcle VIhcle { get; }

		IVIhclecoupon VIhclecoupon { get; }

		IVIhclecoupondetail VIhclecoupondetail { get; }

		IVIhcleservice VIhcleservice { get; }

		IVIhcleserviceconfig VIhcleserviceconfig { get; }

		IVOucher VOucher { get; }

		IVPtemp VPtemp { get; }

		IVPtempr VPtempr { get; }

		IWEbbannerslider WEbbannerslider { get; }

		IWEbbranch WEbbranch { get; }

		IWEbconfig WEbconfig { get; }

		IWEbemployee WEbemployee { get; }

		IWEbfaq WEbfaq { get; }

		IWEbfaqtopic WEbfaqtopic { get; }

		IWEbgallery WEbgallery { get; }

		IWEbgalleryimage WEbgalleryimage { get; }

		IWEbicon WEbicon { get; }

		IWEbimage WEbimage { get; }

		IWEblink WEblink { get; }

		IWEbnews WEbnews { get; }

		IWEbnewscategory WEbnewscategory { get; }

		IWEbpage WEbpage { get; }

		IWEbpartner WEbpartner { get; }

		IWEbreviews WEbreviews { get; }

		IWEbsetting WEbsetting { get; }

		IWEbshoping WEbshoping { get; }

		IWEbshopingdetail WEbshopingdetail { get; }

	}
}
