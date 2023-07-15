using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace LeMaiLogic
{
	public partial class dcDataContextM:IDataContext
	{
		private IACcountobject _ACcountobject;
		public IACcountobject ACcountobject
		{
			get { return _ACcountobject; }
		}

		private IACcountobjectandgroup _ACcountobjectandgroup;
		public IACcountobjectandgroup ACcountobjectandgroup
		{
			get { return _ACcountobjectandgroup; }
		}

		private IACcountobjectbranch _ACcountobjectbranch;
		public IACcountobjectbranch ACcountobjectbranch
		{
			get { return _ACcountobjectbranch; }
		}

		private IACcountobjectcommission _ACcountobjectcommission;
		public IACcountobjectcommission ACcountobjectcommission
		{
			get { return _ACcountobjectcommission; }
		}

		private IACcountobjectgroup _ACcountobjectgroup;
		public IACcountobjectgroup ACcountobjectgroup
		{
			get { return _ACcountobjectgroup; }
		}

		private IACcountobjectimage _ACcountobjectimage;
		public IACcountobjectimage ACcountobjectimage
		{
			get { return _ACcountobjectimage; }
		}

		private IACcountobjectrewardpoint _ACcountobjectrewardpoint;
		public IACcountobjectrewardpoint ACcountobjectrewardpoint
		{
			get { return _ACcountobjectrewardpoint; }
		}

		private IACcountobjecttype _ACcountobjecttype;
		public IACcountobjecttype ACcountobjecttype
		{
			get { return _ACcountobjecttype; }
		}

		private IBOoking _BOoking;
		public IBOoking BOoking
		{
			get { return _BOoking; }
		}

		private IBOokingdetail _BOokingdetail;
		public IBOokingdetail BOokingdetail
		{
			get { return _BOokingdetail; }
		}

		private IBRanch _BRanch;
		public IBRanch BRanch
		{
			get { return _BRanch; }
		}

		private ICAshpay _CAshpay;
		public ICAshpay CAshpay
		{
			get { return _CAshpay; }
		}

		private ICAshpaymoneytype _CAshpaymoneytype;
		public ICAshpaymoneytype CAshpaymoneytype
		{
			get { return _CAshpaymoneytype; }
		}

		private ICAshpaytype _CAshpaytype;
		public ICAshpaytype CAshpaytype
		{
			get { return _CAshpaytype; }
		}

		private ICOnfigbookingtime _COnfigbookingtime;
		public ICOnfigbookingtime COnfigbookingtime
		{
			get { return _COnfigbookingtime; }
		}

		private ICOntacthistory _COntacthistory;
		public ICOntacthistory COntacthistory
		{
			get { return _COntacthistory; }
		}

		private IDYnamicfield _DYnamicfield;
		public IDYnamicfield DYnamicfield
		{
			get { return _DYnamicfield; }
		}

		private IDYnamicfieldtype _DYnamicfieldtype;
		public IDYnamicfieldtype DYnamicfieldtype
		{
			get { return _DYnamicfieldtype; }
		}

		private IDYnamicfilledformfields _DYnamicfilledformfields;
		public IDYnamicfilledformfields DYnamicfilledformfields
		{
			get { return _DYnamicfilledformfields; }
		}

		private IDYnamicfilledforms _DYnamicfilledforms;
		public IDYnamicfilledforms DYnamicfilledforms
		{
			get { return _DYnamicfilledforms; }
		}

		private IDYnamicform _DYnamicform;
		public IDYnamicform DYnamicform
		{
			get { return _DYnamicform; }
		}

		private IDYnamicformfield _DYnamicformfield;
		public IDYnamicformfield DYnamicformfield
		{
			get { return _DYnamicformfield; }
		}

		private IEXpaccountcustomer _EXpaccountcustomer;
		public IEXpaccountcustomer EXpaccountcustomer
		{
			get { return _EXpaccountcustomer; }
		}

		private IEXpautoreport _EXpautoreport;
		public IEXpautoreport EXpautoreport
		{
			get { return _EXpautoreport; }
		}

		private IEXpbalancedetail _EXpbalancedetail;
		public IEXpbalancedetail EXpbalancedetail
		{
			get { return _EXpbalancedetail; }
		}

		private IEXpbalancedetailtype _EXpbalancedetailtype;
		public IEXpbalancedetailtype EXpbalancedetailtype
		{
			get { return _EXpbalancedetailtype; }
		}

		private IEXpbill _EXpbill;
		public IEXpbill EXpbill
		{
			get { return _EXpbill; }
		}

		private IEXpbillprocess _EXpbillprocess;
		public IEXpbillprocess EXpbillprocess
		{
			get { return _EXpbillprocess; }
		}

		private IEXpbillstatus _EXpbillstatus;
		public IEXpbillstatus EXpbillstatus
		{
			get { return _EXpbillstatus; }
		}

		private IEXpcachgiao _EXpcachgiao;
		public IEXpcachgiao EXpcachgiao
		{
			get { return _EXpcachgiao; }
		}

		private IEXpcachthanhtoan _EXpcachthanhtoan;
		public IEXpcachthanhtoan EXpcachthanhtoan
		{
			get { return _EXpcachthanhtoan; }
		}

		private IEXpcalamviec _EXpcalamviec;
		public IEXpcalamviec EXpcalamviec
		{
			get { return _EXpcalamviec; }
		}

		private IEXpcaresale _EXpcaresale;
		public IEXpcaresale EXpcaresale
		{
			get { return _EXpcaresale; }
		}

		private IEXpcaresalehistory _EXpcaresalehistory;
		public IEXpcaresalehistory EXpcaresalehistory
		{
			get { return _EXpcaresalehistory; }
		}

		private IEXpcashpay _EXpcashpay;
		public IEXpcashpay EXpcashpay
		{
			get { return _EXpcashpay; }
		}

		private IEXpcheckbalance _EXpcheckbalance;
		public IEXpcheckbalance EXpcheckbalance
		{
			get { return _EXpcheckbalance; }
		}

		private IEXpcheckbalancedetail _EXpcheckbalancedetail;
		public IEXpcheckbalancedetail EXpcheckbalancedetail
		{
			get { return _EXpcheckbalancedetail; }
		}

		private IEXpchungtu _EXpchungtu;
		public IEXpchungtu EXpchungtu
		{
			get { return _EXpchungtu; }
		}

		private IEXpchungtuct _EXpchungtuct;
		public IEXpchungtuct EXpchungtuct
		{
			get { return _EXpchungtuct; }
		}

		private IEXpcodck _EXpcodck;
		public IEXpcodck EXpcodck
		{
			get { return _EXpcodck; }
		}

		private IEXpcomment _EXpcomment;
		public IEXpcomment EXpcomment
		{
			get { return _EXpcomment; }
		}

		private IEXpcommenttype _EXpcommenttype;
		public IEXpcommenttype EXpcommenttype
		{
			get { return _EXpcommenttype; }
		}

		private IEXpcomplainservice _EXpcomplainservice;
		public IEXpcomplainservice EXpcomplainservice
		{
			get { return _EXpcomplainservice; }
		}

		private IEXpconsigndelivery _EXpconsigndelivery;
		public IEXpconsigndelivery EXpconsigndelivery
		{
			get { return _EXpconsigndelivery; }
		}

		private IEXpconsignment _EXpconsignment;
		public IEXpconsignment EXpconsignment
		{
			get { return _EXpconsignment; }
		}

		private IEXpconsignmentcashpay _EXpconsignmentcashpay;
		public IEXpconsignmentcashpay EXpconsignmentcashpay
		{
			get { return _EXpconsignmentcashpay; }
		}

		private IEXpconsignmentcashpaytype _EXpconsignmentcashpaytype;
		public IEXpconsignmentcashpaytype EXpconsignmentcashpaytype
		{
			get { return _EXpconsignmentcashpaytype; }
		}

		private IEXpconsignmenthistory _EXpconsignmenthistory;
		public IEXpconsignmenthistory EXpconsignmenthistory
		{
			get { return _EXpconsignmenthistory; }
		}

		private IEXpconsignmentobject _EXpconsignmentobject;
		public IEXpconsignmentobject EXpconsignmentobject
		{
			get { return _EXpconsignmentobject; }
		}

		private IEXpconsignmentondelivery _EXpconsignmentondelivery;
		public IEXpconsignmentondelivery EXpconsignmentondelivery
		{
			get { return _EXpconsignmentondelivery; }
		}

		private IEXpconsignmentqueuenumber _EXpconsignmentqueuenumber;
		public IEXpconsignmentqueuenumber EXpconsignmentqueuenumber
		{
			get { return _EXpconsignmentqueuenumber; }
		}

		private IEXpconsignmentstatus _EXpconsignmentstatus;
		public IEXpconsignmentstatus EXpconsignmentstatus
		{
			get { return _EXpconsignmentstatus; }
		}

		private IEXpconsigntransit _EXpconsigntransit;
		public IEXpconsigntransit EXpconsigntransit
		{
			get { return _EXpconsigntransit; }
		}

		private IEXpcontact _EXpcontact;
		public IEXpcontact EXpcontact
		{
			get { return _EXpcontact; }
		}

		private IEXpcontentmessage _EXpcontentmessage;
		public IEXpcontentmessage EXpcontentmessage
		{
			get { return _EXpcontentmessage; }
		}

		private IEXpcost _EXpcost;
		public IEXpcost EXpcost
		{
			get { return _EXpcost; }
		}

		private IEXpcustomer _EXpcustomer;
		public IEXpcustomer EXpcustomer
		{
			get { return _EXpcustomer; }
		}

		private IEXpcustomeraccount _EXpcustomeraccount;
		public IEXpcustomeraccount EXpcustomeraccount
		{
			get { return _EXpcustomeraccount; }
		}

		private IEXpcustomergroup _EXpcustomergroup;
		public IEXpcustomergroup EXpcustomergroup
		{
			get { return _EXpcustomergroup; }
		}

		private IEXpdestination _EXpdestination;
		public IEXpdestination EXpdestination
		{
			get { return _EXpdestination; }
		}

		private IEXpdistance _EXpdistance;
		public IEXpdistance EXpdistance
		{
			get { return _EXpdistance; }
		}

		private IEXpdoisoat _EXpdoisoat;
		public IEXpdoisoat EXpdoisoat
		{
			get { return _EXpdoisoat; }
		}

		private IEXpdoisoatchitiet _EXpdoisoatchitiet;
		public IEXpdoisoatchitiet EXpdoisoatchitiet
		{
			get { return _EXpdoisoatchitiet; }
		}

		private IEXpdoisoatchitietct _EXpdoisoatchitietct;
		public IEXpdoisoatchitietct EXpdoisoatchitietct
		{
			get { return _EXpdoisoatchitietct; }
		}

		private IEXpdonvihanhchinh _EXpdonvihanhchinh;
		public IEXpdonvihanhchinh EXpdonvihanhchinh
		{
			get { return _EXpdonvihanhchinh; }
		}

		private IEXpfee _EXpfee;
		public IEXpfee EXpfee
		{
			get { return _EXpfee; }
		}

		private IEXpgroupfee _EXpgroupfee;
		public IEXpgroupfee EXpgroupfee
		{
			get { return _EXpgroupfee; }
		}

		private IEXphoadondoisoat _EXphoadondoisoat;
		public IEXphoadondoisoat EXphoadondoisoat
		{
			get { return _EXphoadondoisoat; }
		}

		private IEXphoadondoisoatkl _EXphoadondoisoatkl;
		public IEXphoadondoisoatkl EXphoadondoisoatkl
		{
			get { return _EXphoadondoisoatkl; }
		}

		private IEXpinternal _EXpinternal;
		public IEXpinternal EXpinternal
		{
			get { return _EXpinternal; }
		}

		private IEXpkykettoan _EXpkykettoan;
		public IEXpkykettoan EXpkykettoan
		{
			get { return _EXpkykettoan; }
		}

		private IEXploaimathang _EXploaimathang;
		public IEXploaimathang EXploaimathang
		{
			get { return _EXploaimathang; }
		}

		private IEXploancod _EXploancod;
		public IEXploancod EXploancod
		{
			get { return _EXploancod; }
		}

		private IEXplogerrorcheck _EXplogerrorcheck;
		public IEXplogerrorcheck EXplogerrorcheck
		{
			get { return _EXplogerrorcheck; }
		}

		private IEXploinhuanbuucuc _EXploinhuanbuucuc;
		public IEXploinhuanbuucuc EXploinhuanbuucuc
		{
			get { return _EXploinhuanbuucuc; }
		}

		private IEXpmistake _EXpmistake;
		public IEXpmistake EXpmistake
		{
			get { return _EXpmistake; }
		}

		private IEXpnhapkho _EXpnhapkho;
		public IEXpnhapkho EXpnhapkho
		{
			get { return _EXpnhapkho; }
		}

		private IEXpnhapkhoct _EXpnhapkhoct;
		public IEXpnhapkhoct EXpnhapkhoct
		{
			get { return _EXpnhapkhoct; }
		}

		private IEXpnote _EXpnote;
		public IEXpnote EXpnote
		{
			get { return _EXpnote; }
		}

		private IEXpphathanhchungtu _EXpphathanhchungtu;
		public IEXpphathanhchungtu EXpphathanhchungtu
		{
			get { return _EXpphathanhchungtu; }
		}

		private IEXppost _EXppost;
		public IEXppost EXppost
		{
			get { return _EXppost; }
		}

		private IEXppostaccount _EXppostaccount;
		public IEXppostaccount EXppostaccount
		{
			get { return _EXppostaccount; }
		}

		private IEXppostfeeprovider _EXppostfeeprovider;
		public IEXppostfeeprovider EXppostfeeprovider
		{
			get { return _EXppostfeeprovider; }
		}

		private IEXpproblem _EXpproblem;
		public IEXpproblem EXpproblem
		{
			get { return _EXpproblem; }
		}

		private IEXpproviceproblem _EXpproviceproblem;
		public IEXpproviceproblem EXpproviceproblem
		{
			get { return _EXpproviceproblem; }
		}

		private IEXpprovider _EXpprovider;
		public IEXpprovider EXpprovider
		{
			get { return _EXpprovider; }
		}

		private IEXpprovincefee _EXpprovincefee;
		public IEXpprovincefee EXpprovincefee
		{
			get { return _EXpprovincefee; }
		}

		private IEXpprovincefeecustomer _EXpprovincefeecustomer;
		public IEXpprovincefeecustomer EXpprovincefeecustomer
		{
			get { return _EXpprovincefeecustomer; }
		}

		private IEXprecharge _EXprecharge;
		public IEXprecharge EXprecharge
		{
			get { return _EXprecharge; }
		}

		private IEXprecheck _EXprecheck;
		public IEXprecheck EXprecheck
		{
			get { return _EXprecheck; }
		}

		private IEXpsalecongno _EXpsalecongno;
		public IEXpsalecongno EXpsalecongno
		{
			get { return _EXpsalecongno; }
		}

		private IEXpsaleloaithanhtoan _EXpsaleloaithanhtoan;
		public IEXpsaleloaithanhtoan EXpsaleloaithanhtoan
		{
			get { return _EXpsaleloaithanhtoan; }
		}

		private IEXpsalenhapvattu _EXpsalenhapvattu;
		public IEXpsalenhapvattu EXpsalenhapvattu
		{
			get { return _EXpsalenhapvattu; }
		}

		private IEXpsaleproduct _EXpsaleproduct;
		public IEXpsaleproduct EXpsaleproduct
		{
			get { return _EXpsaleproduct; }
		}

		private IEXpsalevattu _EXpsalevattu;
		public IEXpsalevattu EXpsalevattu
		{
			get { return _EXpsalevattu; }
		}

		private IEXpsalexuatkho _EXpsalexuatkho;
		public IEXpsalexuatkho EXpsalexuatkho
		{
			get { return _EXpsalexuatkho; }
		}

		private IEXpscan _EXpscan;
		public IEXpscan EXpscan
		{
			get { return _EXpscan; }
		}

		private IEXpscantt _EXpscantt;
		public IEXpscantt EXpscantt
		{
			get { return _EXpscantt; }
		}

		private IEXpshipper _EXpshipper;
		public IEXpshipper EXpshipper
		{
			get { return _EXpshipper; }
		}

		private IEXpsiteautorun _EXpsiteautorun;
		public IEXpsiteautorun EXpsiteautorun
		{
			get { return _EXpsiteautorun; }
		}

		private IEXptype _EXptype;
		public IEXptype EXptype
		{
			get { return _EXptype; }
		}

		private IEXpwithdrawal _EXpwithdrawal;
		public IEXpwithdrawal EXpwithdrawal
		{
			get { return _EXpwithdrawal; }
		}

		private IEXpwithdrawrequest _EXpwithdrawrequest;
		public IEXpwithdrawrequest EXpwithdrawrequest
		{
			get { return _EXpwithdrawrequest; }
		}

		private IEXpwithdrawrequeststatus _EXpwithdrawrequeststatus;
		public IEXpwithdrawrequeststatus EXpwithdrawrequeststatus
		{
			get { return _EXpwithdrawrequeststatus; }
		}

		private IEXpwithdrawrequesttype _EXpwithdrawrequesttype;
		public IEXpwithdrawrequesttype EXpwithdrawrequesttype
		{
			get { return _EXpwithdrawrequesttype; }
		}

		private IGExpaccept _GExpaccept;
		public IGExpaccept GExpaccept
		{
			get { return _GExpaccept; }
		}

		private IGExpautosign _GExpautosign;
		public IGExpautosign GExpautosign
		{
			get { return _GExpautosign; }
		}

		private IGExpbalancedetail _GExpbalancedetail;
		public IGExpbalancedetail GExpbalancedetail
		{
			get { return _GExpbalancedetail; }
		}

		private IGExpbalancedetailpost _GExpbalancedetailpost;
		public IGExpbalancedetailpost GExpbalancedetailpost
		{
			get { return _GExpbalancedetailpost; }
		}

		private IGExpbalancedetailtype _GExpbalancedetailtype;
		public IGExpbalancedetailtype GExpbalancedetailtype
		{
			get { return _GExpbalancedetailtype; }
		}

		private IGExpbankemail _GExpbankemail;
		public IGExpbankemail GExpbankemail
		{
			get { return _GExpbankemail; }
		}

		private IGExpbankvp _GExpbankvp;
		public IGExpbankvp GExpbankvp
		{
			get { return _GExpbankvp; }
		}

		private IGExpbill _GExpbill;
		public IGExpbill GExpbill
		{
			get { return _GExpbill; }
		}

		private IGExpbillhistory _GExpbillhistory;
		public IGExpbillhistory GExpbillhistory
		{
			get { return _GExpbillhistory; }
		}

		private IGExpbillstatus _GExpbillstatus;
		public IGExpbillstatus GExpbillstatus
		{
			get { return _GExpbillstatus; }
		}

		private IGExpbillstatusname _GExpbillstatusname;
		public IGExpbillstatusname GExpbillstatusname
		{
			get { return _GExpbillstatusname; }
		}

		private IGExpcode _GExpcode;
		public IGExpcode GExpcode
		{
			get { return _GExpcode; }
		}

		private IGExpdebitcomparison _GExpdebitcomparison;
		public IGExpdebitcomparison GExpdebitcomparison
		{
			get { return _GExpdebitcomparison; }
		}

		private IGExpdebitcomparisondetail _GExpdebitcomparisondetail;
		public IGExpdebitcomparisondetail GExpdebitcomparisondetail
		{
			get { return _GExpdebitcomparisondetail; }
		}

		private IGExpdebitsession _GExpdebitsession;
		public IGExpdebitsession GExpdebitsession
		{
			get { return _GExpdebitsession; }
		}

		private IGExpdebitsessiondetail _GExpdebitsessiondetail;
		public IGExpdebitsessiondetail GExpdebitsessiondetail
		{
			get { return _GExpdebitsessiondetail; }
		}

		private IGExpdistrict _GExpdistrict;
		public IGExpdistrict GExpdistrict
		{
			get { return _GExpdistrict; }
		}

		private IGExpdistrictbamboo _GExpdistrictbamboo;
		public IGExpdistrictbamboo GExpdistrictbamboo
		{
			get { return _GExpdistrictbamboo; }
		}

		private IGExpdistrictghsv _GExpdistrictghsv;
		public IGExpdistrictghsv GExpdistrictghsv
		{
			get { return _GExpdistrictghsv; }
		}

		private IGExpdistrictjnt _GExpdistrictjnt;
		public IGExpdistrictjnt GExpdistrictjnt
		{
			get { return _GExpdistrictjnt; }
		}

		private IGExpdistrictvn _GExpdistrictvn;
		public IGExpdistrictvn GExpdistrictvn
		{
			get { return _GExpdistrictvn; }
		}

		private IGExpdistrictvnp _GExpdistrictvnp;
		public IGExpdistrictvnp GExpdistrictvnp
		{
			get { return _GExpdistrictvnp; }
		}

		private IGExpdistrictvtp _GExpdistrictvtp;
		public IGExpdistrictvtp GExpdistrictvtp
		{
			get { return _GExpdistrictvtp; }
		}

		private IGExpdoisoat _GExpdoisoat;
		public IGExpdoisoat GExpdoisoat
		{
			get { return _GExpdoisoat; }
		}

		private IGExpdoisoatchitiet _GExpdoisoatchitiet;
		public IGExpdoisoatchitiet GExpdoisoatchitiet
		{
			get { return _GExpdoisoatchitiet; }
		}

		private IGExpdoisoatchitietct _GExpdoisoatchitietct;
		public IGExpdoisoatchitietct GExpdoisoatchitietct
		{
			get { return _GExpdoisoatchitietct; }
		}

		private IGExpdoisoathistory _GExpdoisoathistory;
		public IGExpdoisoathistory GExpdoisoathistory
		{
			get { return _GExpdoisoathistory; }
		}

		private IGExperror _GExperror;
		public IGExperror GExperror
		{
			get { return _GExperror; }
		}

		private IGExpfee _GExpfee;
		public IGExpfee GExpfee
		{
			get { return _GExpfee; }
		}

		private IGExpfeedebitsession _GExpfeedebitsession;
		public IGExpfeedebitsession GExpfeedebitsession
		{
			get { return _GExpfeedebitsession; }
		}

		private IGExpfeedetail _GExpfeedetail;
		public IGExpfeedetail GExpfeedetail
		{
			get { return _GExpfeedetail; }
		}

		private IGExpfeemaster _GExpfeemaster;
		public IGExpfeemaster GExpfeemaster
		{
			get { return _GExpfeemaster; }
		}

		private IGExpfeeprovincedetail _GExpfeeprovincedetail;
		public IGExpfeeprovincedetail GExpfeeprovincedetail
		{
			get { return _GExpfeeprovincedetail; }
		}

		private IGExpmoneyreturn _GExpmoneyreturn;
		public IGExpmoneyreturn GExpmoneyreturn
		{
			get { return _GExpmoneyreturn; }
		}

		private IGExpmoneyreturnsession _GExpmoneyreturnsession;
		public IGExpmoneyreturnsession GExpmoneyreturnsession
		{
			get { return _GExpmoneyreturnsession; }
		}

		private IGExpmoneyreturnstatus _GExpmoneyreturnstatus;
		public IGExpmoneyreturnstatus GExpmoneyreturnstatus
		{
			get { return _GExpmoneyreturnstatus; }
		}

		private IGExpnotification _GExpnotification;
		public IGExpnotification GExpnotification
		{
			get { return _GExpnotification; }
		}

		private IGExporder _GExporder;
		public IGExporder GExporder
		{
			get { return _GExporder; }
		}

		private IGExporderstatus _GExporderstatus;
		public IGExporderstatus GExporderstatus
		{
			get { return _GExporderstatus; }
		}

		private IGExppaymenttype _GExppaymenttype;
		public IGExppaymenttype GExppaymenttype
		{
			get { return _GExppaymenttype; }
		}

		private IGExpproblem _GExpproblem;
		public IGExpproblem GExpproblem
		{
			get { return _GExpproblem; }
		}

		private IGExpprofit _GExpprofit;
		public IGExpprofit GExpprofit
		{
			get { return _GExpprofit; }
		}

		private IGExpprovider _GExpprovider;
		public IGExpprovider GExpprovider
		{
			get { return _GExpprovider; }
		}

		private IGExpproviderconfig _GExpproviderconfig;
		public IGExpproviderconfig GExpproviderconfig
		{
			get { return _GExpproviderconfig; }
		}

		private IGExpprovidercustomer _GExpprovidercustomer;
		public IGExpprovidercustomer GExpprovidercustomer
		{
			get { return _GExpprovidercustomer; }
		}

		private IGExpprovidersub _GExpprovidersub;
		public IGExpprovidersub GExpprovidersub
		{
			get { return _GExpprovidersub; }
		}

		private IGExpprovidertype _GExpprovidertype;
		public IGExpprovidertype GExpprovidertype
		{
			get { return _GExpprovidertype; }
		}

		private IGExpprovince _GExpprovince;
		public IGExpprovince GExpprovince
		{
			get { return _GExpprovince; }
		}

		private IGExpprovincebamboo _GExpprovincebamboo;
		public IGExpprovincebamboo GExpprovincebamboo
		{
			get { return _GExpprovincebamboo; }
		}

		private IGExpprovincefeez _GExpprovincefeez;
		public IGExpprovincefeez GExpprovincefeez
		{
			get { return _GExpprovincefeez; }
		}

		private IGExpprovinceghsv _GExpprovinceghsv;
		public IGExpprovinceghsv GExpprovinceghsv
		{
			get { return _GExpprovinceghsv; }
		}

		private IGExpprovincejnt _GExpprovincejnt;
		public IGExpprovincejnt GExpprovincejnt
		{
			get { return _GExpprovincejnt; }
		}

		private IGExpprovincevn _GExpprovincevn;
		public IGExpprovincevn GExpprovincevn
		{
			get { return _GExpprovincevn; }
		}

		private IGExpprovincevnp _GExpprovincevnp;
		public IGExpprovincevnp GExpprovincevnp
		{
			get { return _GExpprovincevnp; }
		}

		private IGExpprovincevtp _GExpprovincevtp;
		public IGExpprovincevtp GExpprovincevtp
		{
			get { return _GExpprovincevtp; }
		}

		private IGExpreceivetask _GExpreceivetask;
		public IGExpreceivetask GExpreceivetask
		{
			get { return _GExpreceivetask; }
		}

		private IGExpreceivetaskstatus _GExpreceivetaskstatus;
		public IGExpreceivetaskstatus GExpreceivetaskstatus
		{
			get { return _GExpreceivetaskstatus; }
		}

		private IGExprequestmoney _GExprequestmoney;
		public IGExprequestmoney GExprequestmoney
		{
			get { return _GExprequestmoney; }
		}

		private IGExpscan _GExpscan;
		public IGExpscan GExpscan
		{
			get { return _GExpscan; }
		}

		private IGExpscancome _GExpscancome;
		public IGExpscancome GExpscancome
		{
			get { return _GExpscancome; }
		}

		private IGExpscandelivery _GExpscandelivery;
		public IGExpscandelivery GExpscandelivery
		{
			get { return _GExpscandelivery; }
		}

		private IGExpscanreceive _GExpscanreceive;
		public IGExpscanreceive GExpscanreceive
		{
			get { return _GExpscanreceive; }
		}

		private IGExpscanreturn _GExpscanreturn;
		public IGExpscanreturn GExpscanreturn
		{
			get { return _GExpscanreturn; }
		}

		private IGExpscansend _GExpscansend;
		public IGExpscansend GExpscansend
		{
			get { return _GExpscansend; }
		}

		private IGExpscansign _GExpscansign;
		public IGExpscansign GExpscansign
		{
			get { return _GExpscansign; }
		}

		private IGExpscantype _GExpscantype;
		public IGExpscantype GExpscantype
		{
			get { return _GExpscantype; }
		}

		private IGExpsender _GExpsender;
		public IGExpsender GExpsender
		{
			get { return _GExpsender; }
		}

		private IGExpshipnotetype _GExpshipnotetype;
		public IGExpshipnotetype GExpshipnotetype
		{
			get { return _GExpshipnotetype; }
		}

		private IGExpshipper _GExpshipper;
		public IGExpshipper GExpshipper
		{
			get { return _GExpshipper; }
		}

		private IGExpshipperbillstatus _GExpshipperbillstatus;
		public IGExpshipperbillstatus GExpshipperbillstatus
		{
			get { return _GExpshipperbillstatus; }
		}

		private IGExpshippercash _GExpshippercash;
		public IGExpshippercash GExpshippercash
		{
			get { return _GExpshippercash; }
		}

		private IGExpshippercashdetail _GExpshippercashdetail;
		public IGExpshippercashdetail GExpshippercashdetail
		{
			get { return _GExpshippercashdetail; }
		}

		private IGExpshipperdevivery _GExpshipperdevivery;
		public IGExpshipperdevivery GExpshipperdevivery
		{
			get { return _GExpshipperdevivery; }
		}

		private IGExpward _GExpward;
		public IGExpward GExpward
		{
			get { return _GExpward; }
		}

		private IGExpwardbamboo _GExpwardbamboo;
		public IGExpwardbamboo GExpwardbamboo
		{
			get { return _GExpwardbamboo; }
		}

		private IGExpwardghsv _GExpwardghsv;
		public IGExpwardghsv GExpwardghsv
		{
			get { return _GExpwardghsv; }
		}

		private IGExpwardjnt _GExpwardjnt;
		public IGExpwardjnt GExpwardjnt
		{
			get { return _GExpwardjnt; }
		}

		private IGExpwardvn _GExpwardvn;
		public IGExpwardvn GExpwardvn
		{
			get { return _GExpwardvn; }
		}

		private IGExpwardvnp _GExpwardvnp;
		public IGExpwardvnp GExpwardvnp
		{
			get { return _GExpwardvnp; }
		}

		private IGExpwardvtp _GExpwardvtp;
		public IGExpwardvtp GExpwardvtp
		{
			get { return _GExpwardvtp; }
		}

		private IGExpwebhook _GExpwebhook;
		public IGExpwebhook GExpwebhook
		{
			get { return _GExpwebhook; }
		}

		private IGExpwebhookport _GExpwebhookport;
		public IGExpwebhookport GExpwebhookport
		{
			get { return _GExpwebhookport; }
		}

		private IGExpwithdrawmoney _GExpwithdrawmoney;
		public IGExpwithdrawmoney GExpwithdrawmoney
		{
			get { return _GExpwithdrawmoney; }
		}

		private IGSbank _GSbank;
		public IGSbank GSbank
		{
			get { return _GSbank; }
		}

		private IGScategory _GScategory;
		public IGScategory GScategory
		{
			get { return _GScategory; }
		}

		private IGSccy _GSccy;
		public IGSccy GSccy
		{
			get { return _GSccy; }
		}

		private IGScountry _GScountry;
		public IGScountry GScountry
		{
			get { return _GScountry; }
		}

		private IGScustomeroder _GScustomeroder;
		public IGScustomeroder GScustomeroder
		{
			get { return _GScustomeroder; }
		}

		private IGSkpiaccounttarget _GSkpiaccounttarget;
		public IGSkpiaccounttarget GSkpiaccounttarget
		{
			get { return _GSkpiaccounttarget; }
		}

		private IGSkpiaccounttargetruntime _GSkpiaccounttargetruntime;
		public IGSkpiaccounttargetruntime GSkpiaccounttargetruntime
		{
			get { return _GSkpiaccounttargetruntime; }
		}

		private IGSkpitarget _GSkpitarget;
		public IGSkpitarget GSkpitarget
		{
			get { return _GSkpitarget; }
		}

		private IGSkpitargettype _GSkpitargettype;
		public IGSkpitargettype GSkpitargettype
		{
			get { return _GSkpitargettype; }
		}

		private IGSport _GSport;
		public IGSport GSport
		{
			get { return _GSport; }
		}

		private IGSrequestfindproduct _GSrequestfindproduct;
		public IGSrequestfindproduct GSrequestfindproduct
		{
			get { return _GSrequestfindproduct; }
		}

		private IGSrequestfindproducthistory _GSrequestfindproducthistory;
		public IGSrequestfindproducthistory GSrequestfindproducthistory
		{
			get { return _GSrequestfindproducthistory; }
		}

		private IGSrequestinstance _GSrequestinstance;
		public IGSrequestinstance GSrequestinstance
		{
			get { return _GSrequestinstance; }
		}

		private IGSstepdef _GSstepdef;
		public IGSstepdef GSstepdef
		{
			get { return _GSstepdef; }
		}

		private IGSsteprequestfindproduct _GSsteprequestfindproduct;
		public IGSsteprequestfindproduct GSsteprequestfindproduct
		{
			get { return _GSsteprequestfindproduct; }
		}

		private IGSunit _GSunit;
		public IGSunit GSunit
		{
			get { return _GSunit; }
		}

		private IGSworkflowdef _GSworkflowdef;
		public IGSworkflowdef GSworkflowdef
		{
			get { return _GSworkflowdef; }
		}

		private IINventory _INventory;
		public IINventory INventory
		{
			get { return _INventory; }
		}

		private IINvoice _INvoice;
		public IINvoice INvoice
		{
			get { return _INvoice; }
		}

		private IINvoicedetail _INvoicedetail;
		public IINvoicedetail INvoicedetail
		{
			get { return _INvoicedetail; }
		}

		private IMAmnonclass _MAmnonclass;
		public IMAmnonclass MAmnonclass
		{
			get { return _MAmnonclass; }
		}

		private IMAmnonclasshocvien _MAmnonclasshocvien;
		public IMAmnonclasshocvien MAmnonclasshocvien
		{
			get { return _MAmnonclasshocvien; }
		}

		private IMAmnondiemdanh _MAmnondiemdanh;
		public IMAmnondiemdanh MAmnondiemdanh
		{
			get { return _MAmnondiemdanh; }
		}

		private IMAmnonhocvien _MAmnonhocvien;
		public IMAmnonhocvien MAmnonhocvien
		{
			get { return _MAmnonhocvien; }
		}

		private IMAmnonsodaubai _MAmnonsodaubai;
		public IMAmnonsodaubai MAmnonsodaubai
		{
			get { return _MAmnonsodaubai; }
		}

		private IMAmnonthangdiem _MAmnonthangdiem;
		public IMAmnonthangdiem MAmnonthangdiem
		{
			get { return _MAmnonthangdiem; }
		}

		private IMAmnonthuhocphi _MAmnonthuhocphi;
		public IMAmnonthuhocphi MAmnonthuhocphi
		{
			get { return _MAmnonthuhocphi; }
		}

		private IMAmnontruonghoc _MAmnontruonghoc;
		public IMAmnontruonghoc MAmnontruonghoc
		{
			get { return _MAmnontruonghoc; }
		}

		private IMEdbacsicdha _MEdbacsicdha;
		public IMEdbacsicdha MEdbacsicdha
		{
			get { return _MEdbacsicdha; }
		}

		private IMEdbenhnhan _MEdbenhnhan;
		public IMEdbenhnhan MEdbenhnhan
		{
			get { return _MEdbenhnhan; }
		}

		private IMEdcapmaso _MEdcapmaso;
		public IMEdcapmaso MEdcapmaso
		{
			get { return _MEdcapmaso; }
		}

		private IMEdchidinh _MEdchidinh;
		public IMEdchidinh MEdchidinh
		{
			get { return _MEdchidinh; }
		}

		private IMEdchidinhsync _MEdchidinhsync;
		public IMEdchidinhsync MEdchidinhsync
		{
			get { return _MEdchidinhsync; }
		}

		private IMEdcoso _MEdcoso;
		public IMEdcoso MEdcoso
		{
			get { return _MEdcoso; }
		}

		private IMEdcotbaocao _MEdcotbaocao;
		public IMEdcotbaocao MEdcotbaocao
		{
			get { return _MEdcotbaocao; }
		}

		private IMEddmdonvi _MEddmdonvi;
		public IMEddmdonvi MEddmdonvi
		{
			get { return _MEddmdonvi; }
		}

		private IMEddmketqua _MEddmketqua;
		public IMEddmketqua MEddmketqua
		{
			get { return _MEddmketqua; }
		}

		private IMEddmmay _MEddmmay;
		public IMEddmmay MEddmmay
		{
			get { return _MEddmmay; }
		}

		private IMEddmso _MEddmso;
		public IMEddmso MEddmso
		{
			get { return _MEddmso; }
		}

		private IMEddmten _MEddmten;
		public IMEddmten MEddmten
		{
			get { return _MEddmten; }
		}

		private IMEdgiavp _MEdgiavp;
		public IMEdgiavp MEdgiavp
		{
			get { return _MEdgiavp; }
		}

		private IMEdhistory _MEdhistory;
		public IMEdhistory MEdhistory
		{
			get { return _MEdhistory; }
		}

		private IMEdhistoryct _MEdhistoryct;
		public IMEdhistoryct MEdhistoryct
		{
			get { return _MEdhistoryct; }
		}

		private IMEdhosonhanbenh _MEdhosonhanbenh;
		public IMEdhosonhanbenh MEdhosonhanbenh
		{
			get { return _MEdhosonhanbenh; }
		}

		private IMEdketluanmau _MEdketluanmau;
		public IMEdketluanmau MEdketluanmau
		{
			get { return _MEdketluanmau; }
		}

		private IMEdketqua _MEdketqua;
		public IMEdketqua MEdketqua
		{
			get { return _MEdketqua; }
		}

		private IMEdketquaautotext _MEdketquaautotext;
		public IMEdketquaautotext MEdketquaautotext
		{
			get { return _MEdketquaautotext; }
		}

		private IMEdketquachandoan _MEdketquachandoan;
		public IMEdketquachandoan MEdketquachandoan
		{
			get { return _MEdketquachandoan; }
		}

		private IMEdketquachandoanha _MEdketquachandoanha;
		public IMEdketquachandoanha MEdketquachandoanha
		{
			get { return _MEdketquachandoanha; }
		}

		private IMEdketquact _MEdketquact;
		public IMEdketquact MEdketquact
		{
			get { return _MEdketquact; }
		}

		private IMEdketquadcm _MEdketquadcm;
		public IMEdketquadcm MEdketquadcm
		{
			get { return _MEdketquadcm; }
		}

		private IMEdketquaecg _MEdketquaecg;
		public IMEdketquaecg MEdketquaecg
		{
			get { return _MEdketquaecg; }
		}

		private IMEdketquamacdinh _MEdketquamacdinh;
		public IMEdketquamacdinh MEdketquamacdinh
		{
			get { return _MEdketquamacdinh; }
		}

		private IMEdketquamayxn _MEdketquamayxn;
		public IMEdketquamayxn MEdketquamayxn
		{
			get { return _MEdketquamayxn; }
		}

		private IMEdketquaxn _MEdketquaxn;
		public IMEdketquaxn MEdketquaxn
		{
			get { return _MEdketquaxn; }
		}

		private IMEdkhoaphong _MEdkhoaphong;
		public IMEdkhoaphong MEdkhoaphong
		{
			get { return _MEdkhoaphong; }
		}

		private IMEdlaymau _MEdlaymau;
		public IMEdlaymau MEdlaymau
		{
			get { return _MEdlaymau; }
		}

		private IMEdlaymauct _MEdlaymauct;
		public IMEdlaymauct MEdlaymauct
		{
			get { return _MEdlaymauct; }
		}

		private IMEdloaikhoaphong _MEdloaikhoaphong;
		public IMEdloaikhoaphong MEdloaikhoaphong
		{
			get { return _MEdloaikhoaphong; }
		}

		private IMEdloaivp _MEdloaivp;
		public IMEdloaivp MEdloaivp
		{
			get { return _MEdloaivp; }
		}

		private IMEdlogin _MEdlogin;
		public IMEdlogin MEdlogin
		{
			get { return _MEdlogin; }
		}

		private IMEdmaso _MEdmaso;
		public IMEdmaso MEdmaso
		{
			get { return _MEdmaso; }
		}

		private IMEdmauin _MEdmauin;
		public IMEdmauin MEdmauin
		{
			get { return _MEdmauin; }
		}

		private IMEdmauketqua _MEdmauketqua;
		public IMEdmauketqua MEdmauketqua
		{
			get { return _MEdmauketqua; }
		}

		private IMEdmayxn _MEdmayxn;
		public IMEdmayxn MEdmayxn
		{
			get { return _MEdmayxn; }
		}

		private IMEdnhombenhnhan _MEdnhombenhnhan;
		public IMEdnhombenhnhan MEdnhombenhnhan
		{
			get { return _MEdnhombenhnhan; }
		}

		private IMEdnhomvp _MEdnhomvp;
		public IMEdnhomvp MEdnhomvp
		{
			get { return _MEdnhomvp; }
		}

		private IMEdphieunhanbenh _MEdphieunhanbenh;
		public IMEdphieunhanbenh MEdphieunhanbenh
		{
			get { return _MEdphieunhanbenh; }
		}

		private IMEdphieunhanbenhchitiet _MEdphieunhanbenhchitiet;
		public IMEdphieunhanbenhchitiet MEdphieunhanbenhchitiet
		{
			get { return _MEdphieunhanbenhchitiet; }
		}

		private IMEdserver _MEdserver;
		public IMEdserver MEdserver
		{
			get { return _MEdserver; }
		}

		private IMEdsetting _MEdsetting;
		public IMEdsetting MEdsetting
		{
			get { return _MEdsetting; }
		}

		private IMEdsomauxetnghiem _MEdsomauxetnghiem;
		public IMEdsomauxetnghiem MEdsomauxetnghiem
		{
			get { return _MEdsomauxetnghiem; }
		}

		private IMEdthongsokqmayxn _MEdthongsokqmayxn;
		public IMEdthongsokqmayxn MEdthongsokqmayxn
		{
			get { return _MEdthongsokqmayxn; }
		}

		private IMEdticcapmaso _MEdticcapmaso;
		public IMEdticcapmaso MEdticcapmaso
		{
			get { return _MEdticcapmaso; }
		}

		private IMEdworkspace _MEdworkspace;
		public IMEdworkspace MEdworkspace
		{
			get { return _MEdworkspace; }
		}

		private IMEdxnloai _MEdxnloai;
		public IMEdxnloai MEdxnloai
		{
			get { return _MEdxnloai; }
		}

		private IMEdxnloaimay _MEdxnloaimay;
		public IMEdxnloaimay MEdxnloaimay
		{
			get { return _MEdxnloaimay; }
		}

		private IMEdxnten _MEdxnten;
		public IMEdxnten MEdxnten
		{
			get { return _MEdxnten; }
		}

		private IMEdxnthongsomay _MEdxnthongsomay;
		public IMEdxnthongsomay MEdxnthongsomay
		{
			get { return _MEdxnthongsomay; }
		}

		private IMEdxnthongsomayct _MEdxnthongsomayct;
		public IMEdxnthongsomayct MEdxnthongsomayct
		{
			get { return _MEdxnthongsomayct; }
		}

		private IMEnufunction _MEnufunction;
		public IMEnufunction MEnufunction
		{
			get { return _MEnufunction; }
		}

		private IMEnufunctionaccount _MEnufunctionaccount;
		public IMEnufunctionaccount MEnufunctionaccount
		{
			get { return _MEnufunctionaccount; }
		}

		private IMEnufunctionrole _MEnufunctionrole;
		public IMEnufunctionrole MEnufunctionrole
		{
			get { return _MEnufunctionrole; }
		}

		private IMEnufunctiongroup _MEnufunctiongroup;
		public IMEnufunctiongroup MEnufunctiongroup
		{
			get { return _MEnufunctiongroup; }
		}

		private IMEnuimage _MEnuimage;
		public IMEnuimage MEnuimage
		{
			get { return _MEnuimage; }
		}

		private IMEnurole _MEnurole;
		public IMEnurole MEnurole
		{
			get { return _MEnurole; }
		}

		private IMEnuroleaccountobject _MEnuroleaccountobject;
		public IMEnuroleaccountobject MEnuroleaccountobject
		{
			get { return _MEnuroleaccountobject; }
		}

		private IPRoductquota _PRoductquota;
		public IPRoductquota PRoductquota
		{
			get { return _PRoductquota; }
		}

		private IQUeuenumber _QUeuenumber;
		public IQUeuenumber QUeuenumber
		{
			get { return _QUeuenumber; }
		}

		private IROom _ROom;
		public IROom ROom
		{
			get { return _ROom; }
		}

		private IROomgroup _ROomgroup;
		public IROomgroup ROomgroup
		{
			get { return _ROomgroup; }
		}

		private ISAlebalancedetail _SAlebalancedetail;
		public ISAlebalancedetail SAlebalancedetail
		{
			get { return _SAlebalancedetail; }
		}

		private ISAlebanggia _SAlebanggia;
		public ISAlebanggia SAlebanggia
		{
			get { return _SAlebanggia; }
		}

		private ISAlebanggiachitiet _SAlebanggiachitiet;
		public ISAlebanggiachitiet SAlebanggiachitiet
		{
			get { return _SAlebanggiachitiet; }
		}

		private ISAlehoadon _SAlehoadon;
		public ISAlehoadon SAlehoadon
		{
			get { return _SAlehoadon; }
		}

		private ISAlehoadonchitiet _SAlehoadonchitiet;
		public ISAlehoadonchitiet SAlehoadonchitiet
		{
			get { return _SAlehoadonchitiet; }
		}

		private ISAlekhachhang _SAlekhachhang;
		public ISAlekhachhang SAlekhachhang
		{
			get { return _SAlekhachhang; }
		}

		private ISAlenhomsanpham _SAlenhomsanpham;
		public ISAlenhomsanpham SAlenhomsanpham
		{
			get { return _SAlenhomsanpham; }
		}

		private ISAlesanpham _SAlesanpham;
		public ISAlesanpham SAlesanpham
		{
			get { return _SAlesanpham; }
		}

		private ISChoolcapbac _SChoolcapbac;
		public ISChoolcapbac SChoolcapbac
		{
			get { return _SChoolcapbac; }
		}

		private ISChoolgiaotrinh _SChoolgiaotrinh;
		public ISChoolgiaotrinh SChoolgiaotrinh
		{
			get { return _SChoolgiaotrinh; }
		}

		private ISChoolgiaotrinhhocphan _SChoolgiaotrinhhocphan;
		public ISChoolgiaotrinhhocphan SChoolgiaotrinhhocphan
		{
			get { return _SChoolgiaotrinhhocphan; }
		}

		private ISChoolhocphan _SChoolhocphan;
		public ISChoolhocphan SChoolhocphan
		{
			get { return _SChoolhocphan; }
		}

		private ISChoolhocvien _SChoolhocvien;
		public ISChoolhocvien SChoolhocvien
		{
			get { return _SChoolhocvien; }
		}

		private ISChoolphonggiaoduc _SChoolphonggiaoduc;
		public ISChoolphonggiaoduc SChoolphonggiaoduc
		{
			get { return _SChoolphonggiaoduc; }
		}

		private ISChoolprogram _SChoolprogram;
		public ISChoolprogram SChoolprogram
		{
			get { return _SChoolprogram; }
		}

		private ISChoolroom _SChoolroom;
		public ISChoolroom SChoolroom
		{
			get { return _SChoolroom; }
		}

		private ISChoolsogiaoduc _SChoolsogiaoduc;
		public ISChoolsogiaoduc SChoolsogiaoduc
		{
			get { return _SChoolsogiaoduc; }
		}

		private ISChooltrungtamav _SChooltrungtamav;
		public ISChooltrungtamav SChooltrungtamav
		{
			get { return _SChooltrungtamav; }
		}

		private ISErvice _SErvice;
		public ISErvice SErvice
		{
			get { return _SErvice; }
		}

		private ISErvicecombo _SErvicecombo;
		public ISErvicecombo SErvicecombo
		{
			get { return _SErvicecombo; }
		}

		private ISErvicegroup _SErvicegroup;
		public ISErvicegroup SErvicegroup
		{
			get { return _SErvicegroup; }
		}

		private ISErviceimage _SErviceimage;
		public ISErviceimage SErviceimage
		{
			get { return _SErviceimage; }
		}

		private ISEtting _SEtting;
		public ISEtting SEtting
		{
			get { return _SEtting; }
		}

		private ISEttingbranch _SEttingbranch;
		public ISEttingbranch SEttingbranch
		{
			get { return _SEttingbranch; }
		}

		private ISTock _STock;
		public ISTock STock
		{
			get { return _STock; }
		}

		private ISTockimportexport _STockimportexport;
		public ISTockimportexport STockimportexport
		{
			get { return _STockimportexport; }
		}

		private ISTockimportexportdetail _STockimportexportdetail;
		public ISTockimportexportdetail STockimportexportdetail
		{
			get { return _STockimportexportdetail; }
		}

		private ISYsdiagrams _SYsdiagrams;
		public ISYsdiagrams SYsdiagrams
		{
			get { return _SYsdiagrams; }
		}

		private ITAskactionhistory _TAskactionhistory;
		public ITAskactionhistory TAskactionhistory
		{
			get { return _TAskactionhistory; }
		}

		private ITAskissue _TAskissue;
		public ITAskissue TAskissue
		{
			get { return _TAskissue; }
		}

		private ITAskissuepriority _TAskissuepriority;
		public ITAskissuepriority TAskissuepriority
		{
			get { return _TAskissuepriority; }
		}

		private ITAskissuestatus _TAskissuestatus;
		public ITAskissuestatus TAskissuestatus
		{
			get { return _TAskissuestatus; }
		}

		private ITAskissuetracker _TAskissuetracker;
		public ITAskissuetracker TAskissuetracker
		{
			get { return _TAskissuetracker; }
		}

		private IVCkettoan _VCkettoan;
		public IVCkettoan VCkettoan
		{
			get { return _VCkettoan; }
		}

		private IVCkhachhang _VCkhachhang;
		public IVCkhachhang VCkhachhang
		{
			get { return _VCkhachhang; }
		}

		private IVCloaichiphi _VCloaichiphi;
		public IVCloaichiphi VCloaichiphi
		{
			get { return _VCloaichiphi; }
		}

		private IVCmathang _VCmathang;
		public IVCmathang VCmathang
		{
			get { return _VCmathang; }
		}

		private IVCnhacungcap _VCnhacungcap;
		public IVCnhacungcap VCnhacungcap
		{
			get { return _VCnhacungcap; }
		}

		private IVCnhaphang _VCnhaphang;
		public IVCnhaphang VCnhaphang
		{
			get { return _VCnhaphang; }
		}

		private IVCxuathang _VCxuathang;
		public IVCxuathang VCxuathang
		{
			get { return _VCxuathang; }
		}

		private IVIewaccountobject _VIewaccountobject;
		public IVIewaccountobject VIewaccountobject
		{
			get { return _VIewaccountobject; }
		}

		private IVIewautosigndelivery _VIewautosigndelivery;
		public IVIewautosigndelivery VIewautosigndelivery
		{
			get { return _VIewautosigndelivery; }
		}

		private IVIewbaocaotaichinh _VIewbaocaotaichinh;
		public IVIewbaocaotaichinh VIewbaocaotaichinh
		{
			get { return _VIewbaocaotaichinh; }
		}

		private IVIewbooking _VIewbooking;
		public IVIewbooking VIewbooking
		{
			get { return _VIewbooking; }
		}

		private IVIewbranch _VIewbranch;
		public IVIewbranch VIewbranch
		{
			get { return _VIewbranch; }
		}

		private IVIewcashpay _VIewcashpay;
		public IVIewcashpay VIewcashpay
		{
			get { return _VIewcashpay; }
		}

		private IVIewdoisoatchitiet _VIewdoisoatchitiet;
		public IVIewdoisoatchitiet VIewdoisoatchitiet
		{
			get { return _VIewdoisoatchitiet; }
		}

		private IVIewexpbill _VIewexpbill;
		public IVIewexpbill VIewexpbill
		{
			get { return _VIewexpbill; }
		}

		private IVIewexpbillhoadondoisoat _VIewexpbillhoadondoisoat;
		public IVIewexpbillhoadondoisoat VIewexpbillhoadondoisoat
		{
			get { return _VIewexpbillhoadondoisoat; }
		}

		private IVIewexpcashpay _VIewexpcashpay;
		public IVIewexpcashpay VIewexpcashpay
		{
			get { return _VIewexpcashpay; }
		}

		private IVIewexpchungtu _VIewexpchungtu;
		public IVIewexpchungtu VIewexpchungtu
		{
			get { return _VIewexpchungtu; }
		}

		private IVIewexpchungtuct _VIewexpchungtuct;
		public IVIewexpchungtuct VIewexpchungtuct
		{
			get { return _VIewexpchungtuct; }
		}

		private IVIewexpchungtuctreport _VIewexpchungtuctreport;
		public IVIewexpchungtuctreport VIewexpchungtuctreport
		{
			get { return _VIewexpchungtuctreport; }
		}

		private IVIewexpchungtuphieuchi _VIewexpchungtuphieuchi;
		public IVIewexpchungtuphieuchi VIewexpchungtuphieuchi
		{
			get { return _VIewexpchungtuphieuchi; }
		}

		private IVIewexpcodck _VIewexpcodck;
		public IVIewexpcodck VIewexpcodck
		{
			get { return _VIewexpcodck; }
		}

		private IVIewexpcomment _VIewexpcomment;
		public IVIewexpcomment VIewexpcomment
		{
			get { return _VIewexpcomment; }
		}

		private IVIewexpconsigndelivery _VIewexpconsigndelivery;
		public IVIewexpconsigndelivery VIewexpconsigndelivery
		{
			get { return _VIewexpconsigndelivery; }
		}

		private IVIewexpconsignment _VIewexpconsignment;
		public IVIewexpconsignment VIewexpconsignment
		{
			get { return _VIewexpconsignment; }
		}

		private IVIewexpconsignmentcashpay _VIewexpconsignmentcashpay;
		public IVIewexpconsignmentcashpay VIewexpconsignmentcashpay
		{
			get { return _VIewexpconsignmentcashpay; }
		}

		private IVIewexpconsignmenthistory _VIewexpconsignmenthistory;
		public IVIewexpconsignmenthistory VIewexpconsignmenthistory
		{
			get { return _VIewexpconsignmenthistory; }
		}

		private IVIewexpconsignmenthistorymater _VIewexpconsignmenthistorymater;
		public IVIewexpconsignmenthistorymater VIewexpconsignmenthistorymater
		{
			get { return _VIewexpconsignmenthistorymater; }
		}

		private IVIewexpconsignmentobject _VIewexpconsignmentobject;
		public IVIewexpconsignmentobject VIewexpconsignmentobject
		{
			get { return _VIewexpconsignmentobject; }
		}

		private IVIewexpconsigntransit _VIewexpconsigntransit;
		public IVIewexpconsigntransit VIewexpconsigntransit
		{
			get { return _VIewexpconsigntransit; }
		}

		private IVIewexpcustomer _VIewexpcustomer;
		public IVIewexpcustomer VIewexpcustomer
		{
			get { return _VIewexpcustomer; }
		}

		private IVIewexpcustomergroup _VIewexpcustomergroup;
		public IVIewexpcustomergroup VIewexpcustomergroup
		{
			get { return _VIewexpcustomergroup; }
		}

		private IVIewexpdvhchuyen _VIewexpdvhchuyen;
		public IVIewexpdvhchuyen VIewexpdvhchuyen
		{
			get { return _VIewexpdvhchuyen; }
		}

		private IVIewexpdvhctinh _VIewexpdvhctinh;
		public IVIewexpdvhctinh VIewexpdvhctinh
		{
			get { return _VIewexpdvhctinh; }
		}

		private IVIewexpdvhcxa _VIewexpdvhcxa;
		public IVIewexpdvhcxa VIewexpdvhcxa
		{
			get { return _VIewexpdvhcxa; }
		}

		private IVIewexpkykettoan _VIewexpkykettoan;
		public IVIewexpkykettoan VIewexpkykettoan
		{
			get { return _VIewexpkykettoan; }
		}

		private IVIewexploancod _VIewexploancod;
		public IVIewexploancod VIewexploancod
		{
			get { return _VIewexploancod; }
		}

		private IVIewexpnhapkho _VIewexpnhapkho;
		public IVIewexpnhapkho VIewexpnhapkho
		{
			get { return _VIewexpnhapkho; }
		}

		private IVIewexpnhapkhoct _VIewexpnhapkhoct;
		public IVIewexpnhapkhoct VIewexpnhapkhoct
		{
			get { return _VIewexpnhapkhoct; }
		}

		private IVIewexppost _VIewexppost;
		public IVIewexppost VIewexppost
		{
			get { return _VIewexppost; }
		}

		private IVIewexpproviceproblem _VIewexpproviceproblem;
		public IVIewexpproviceproblem VIewexpproviceproblem
		{
			get { return _VIewexpproviceproblem; }
		}

		private IVIewexprecharge _VIewexprecharge;
		public IVIewexprecharge VIewexprecharge
		{
			get { return _VIewexprecharge; }
		}

		private IVIewexpsalenhapvattu _VIewexpsalenhapvattu;
		public IVIewexpsalenhapvattu VIewexpsalenhapvattu
		{
			get { return _VIewexpsalenhapvattu; }
		}

		private IVIewexpsalexuatkho _VIewexpsalexuatkho;
		public IVIewexpsalexuatkho VIewexpsalexuatkho
		{
			get { return _VIewexpsalexuatkho; }
		}

		private IVIewexptotalchungtu _VIewexptotalchungtu;
		public IVIewexptotalchungtu VIewexptotalchungtu
		{
			get { return _VIewexptotalchungtu; }
		}

		private IVIewexpwithdrawrequest _VIewexpwithdrawrequest;
		public IVIewexpwithdrawrequest VIewexpwithdrawrequest
		{
			get { return _VIewexpwithdrawrequest; }
		}

		private IVIewgexpautosign _VIewgexpautosign;
		public IVIewgexpautosign VIewgexpautosign
		{
			get { return _VIewgexpautosign; }
		}

		private IVIewgexpbalancedetail _VIewgexpbalancedetail;
		public IVIewgexpbalancedetail VIewgexpbalancedetail
		{
			get { return _VIewgexpbalancedetail; }
		}

		private IVIewgexpbalancedetailpost _VIewgexpbalancedetailpost;
		public IVIewgexpbalancedetailpost VIewgexpbalancedetailpost
		{
			get { return _VIewgexpbalancedetailpost; }
		}

		private IVIewgexpbill _VIewgexpbill;
		public IVIewgexpbill VIewgexpbill
		{
			get { return _VIewgexpbill; }
		}

		private IVIewgexpbillcus _VIewgexpbillcus;
		public IVIewgexpbillcus VIewgexpbillcus
		{
			get { return _VIewgexpbillcus; }
		}

		private IVIewgexpbilldelivery _VIewgexpbilldelivery;
		public IVIewgexpbilldelivery VIewgexpbilldelivery
		{
			get { return _VIewgexpbilldelivery; }
		}

		private IVIewgexpbillghn _VIewgexpbillghn;
		public IVIewgexpbillghn VIewgexpbillghn
		{
			get { return _VIewgexpbillghn; }
		}

		private IVIewgexpbillghnapi _VIewgexpbillghnapi;
		public IVIewgexpbillghnapi VIewgexpbillghnapi
		{
			get { return _VIewgexpbillghnapi; }
		}

		private IVIewgexpbillhistory _VIewgexpbillhistory;
		public IVIewgexpbillhistory VIewgexpbillhistory
		{
			get { return _VIewgexpbillhistory; }
		}

		private IVIewgexpbillmaster _VIewgexpbillmaster;
		public IVIewgexpbillmaster VIewgexpbillmaster
		{
			get { return _VIewgexpbillmaster; }
		}

		private IVIewgexpdebitcomparison _VIewgexpdebitcomparison;
		public IVIewgexpdebitcomparison VIewgexpdebitcomparison
		{
			get { return _VIewgexpdebitcomparison; }
		}

		private IVIewgexpdebitcomparisondetail _VIewgexpdebitcomparisondetail;
		public IVIewgexpdebitcomparisondetail VIewgexpdebitcomparisondetail
		{
			get { return _VIewgexpdebitcomparisondetail; }
		}

		private IVIewgexpdoisoatchitiet _VIewgexpdoisoatchitiet;
		public IVIewgexpdoisoatchitiet VIewgexpdoisoatchitiet
		{
			get { return _VIewgexpdoisoatchitiet; }
		}

		private IVIewgexpfee _VIewgexpfee;
		public IVIewgexpfee VIewgexpfee
		{
			get { return _VIewgexpfee; }
		}

		private IVIewgexpfeedebitsession _VIewgexpfeedebitsession;
		public IVIewgexpfeedebitsession VIewgexpfeedebitsession
		{
			get { return _VIewgexpfeedebitsession; }
		}

		private IVIewgexpfeedetails _VIewgexpfeedetails;
		public IVIewgexpfeedetails VIewgexpfeedetails
		{
			get { return _VIewgexpfeedetails; }
		}

		private IVIewgexpfeedetailspro _VIewgexpfeedetailspro;
		public IVIewgexpfeedetailspro VIewgexpfeedetailspro
		{
			get { return _VIewgexpfeedetailspro; }
		}

		private IVIewgexpmoneyreturn _VIewgexpmoneyreturn;
		public IVIewgexpmoneyreturn VIewgexpmoneyreturn
		{
			get { return _VIewgexpmoneyreturn; }
		}

		private IVIewgexpmoneyreturnsession _VIewgexpmoneyreturnsession;
		public IVIewgexpmoneyreturnsession VIewgexpmoneyreturnsession
		{
			get { return _VIewgexpmoneyreturnsession; }
		}

		private IVIewgexpnotification _VIewgexpnotification;
		public IVIewgexpnotification VIewgexpnotification
		{
			get { return _VIewgexpnotification; }
		}

		private IVIewgexporder _VIewgexporder;
		public IVIewgexporder VIewgexporder
		{
			get { return _VIewgexporder; }
		}

		private IVIewgexpproblem _VIewgexpproblem;
		public IVIewgexpproblem VIewgexpproblem
		{
			get { return _VIewgexpproblem; }
		}

		private IVIewgexpprovider _VIewgexpprovider;
		public IVIewgexpprovider VIewgexpprovider
		{
			get { return _VIewgexpprovider; }
		}

		private IVIewgexpreceivetask _VIewgexpreceivetask;
		public IVIewgexpreceivetask VIewgexpreceivetask
		{
			get { return _VIewgexpreceivetask; }
		}

		private IVIewgexprequestmoney _VIewgexprequestmoney;
		public IVIewgexprequestmoney VIewgexprequestmoney
		{
			get { return _VIewgexprequestmoney; }
		}

		private IVIewgexpscan _VIewgexpscan;
		public IVIewgexpscan VIewgexpscan
		{
			get { return _VIewgexpscan; }
		}

		private IVIewgexpscancome _VIewgexpscancome;
		public IVIewgexpscancome VIewgexpscancome
		{
			get { return _VIewgexpscancome; }
		}

		private IVIewgexpscandelivery _VIewgexpscandelivery;
		public IVIewgexpscandelivery VIewgexpscandelivery
		{
			get { return _VIewgexpscandelivery; }
		}

		private IVIewgexpscanreturn _VIewgexpscanreturn;
		public IVIewgexpscanreturn VIewgexpscanreturn
		{
			get { return _VIewgexpscanreturn; }
		}

		private IVIewgexpscansend _VIewgexpscansend;
		public IVIewgexpscansend VIewgexpscansend
		{
			get { return _VIewgexpscansend; }
		}

		private IVIewgexpscansign _VIewgexpscansign;
		public IVIewgexpscansign VIewgexpscansign
		{
			get { return _VIewgexpscansign; }
		}

		private IVIewgexpshipper _VIewgexpshipper;
		public IVIewgexpshipper VIewgexpshipper
		{
			get { return _VIewgexpshipper; }
		}

		private IVIewgexpshippercash _VIewgexpshippercash;
		public IVIewgexpshippercash VIewgexpshippercash
		{
			get { return _VIewgexpshippercash; }
		}

		private IVIewgexpshippercashdetail _VIewgexpshippercashdetail;
		public IVIewgexpshippercashdetail VIewgexpshippercashdetail
		{
			get { return _VIewgexpshippercashdetail; }
		}

		private IVIewgexpshipperdevivery _VIewgexpshipperdevivery;
		public IVIewgexpshipperdevivery VIewgexpshipperdevivery
		{
			get { return _VIewgexpshipperdevivery; }
		}

		private IVIewgexpwithdrawmoney _VIewgexpwithdrawmoney;
		public IVIewgexpwithdrawmoney VIewgexpwithdrawmoney
		{
			get { return _VIewgexpwithdrawmoney; }
		}

		private IVIewinvoicelist _VIewinvoicelist;
		public IVIewinvoicelist VIewinvoicelist
		{
			get { return _VIewinvoicelist; }
		}

		private IVIewinvoiceprint _VIewinvoiceprint;
		public IVIewinvoiceprint VIewinvoiceprint
		{
			get { return _VIewinvoiceprint; }
		}

		private IVIewmamnontruonghoc _VIewmamnontruonghoc;
		public IVIewmamnontruonghoc VIewmamnontruonghoc
		{
			get { return _VIewmamnontruonghoc; }
		}

		private IVIewmenufunction _VIewmenufunction;
		public IVIewmenufunction VIewmenufunction
		{
			get { return _VIewmenufunction; }
		}

		private IVIewmenufunctionaccount _VIewmenufunctionaccount;
		public IVIewmenufunctionaccount VIewmenufunctionaccount
		{
			get { return _VIewmenufunctionaccount; }
		}

		private IVIewrole _VIewrole;
		public IVIewrole VIewrole
		{
			get { return _VIewrole; }
		}

		private IVIewroom _VIewroom;
		public IVIewroom VIewroom
		{
			get { return _VIewroom; }
		}

		private IVIewroomgroup _VIewroomgroup;
		public IVIewroomgroup VIewroomgroup
		{
			get { return _VIewroomgroup; }
		}

		private IVIewschoolgiaotrinh _VIewschoolgiaotrinh;
		public IVIewschoolgiaotrinh VIewschoolgiaotrinh
		{
			get { return _VIewschoolgiaotrinh; }
		}

		private IVIewschoolgiaotrinhhocphan _VIewschoolgiaotrinhhocphan;
		public IVIewschoolgiaotrinhhocphan VIewschoolgiaotrinhhocphan
		{
			get { return _VIewschoolgiaotrinhhocphan; }
		}

		private IVIewschoolhocphan _VIewschoolhocphan;
		public IVIewschoolhocphan VIewschoolhocphan
		{
			get { return _VIewschoolhocphan; }
		}

		private IVIewschoolphonggiaoduc _VIewschoolphonggiaoduc;
		public IVIewschoolphonggiaoduc VIewschoolphonggiaoduc
		{
			get { return _VIewschoolphonggiaoduc; }
		}

		private IVIewschoolprogram _VIewschoolprogram;
		public IVIewschoolprogram VIewschoolprogram
		{
			get { return _VIewschoolprogram; }
		}

		private IVIewschoolroom _VIewschoolroom;
		public IVIewschoolroom VIewschoolroom
		{
			get { return _VIewschoolroom; }
		}

		private IVIewschoolsogiaoduc _VIewschoolsogiaoduc;
		public IVIewschoolsogiaoduc VIewschoolsogiaoduc
		{
			get { return _VIewschoolsogiaoduc; }
		}

		private IVIewschooltrungtamav _VIewschooltrungtamav;
		public IVIewschooltrungtamav VIewschooltrungtamav
		{
			get { return _VIewschooltrungtamav; }
		}

		private IVIewservice _VIewservice;
		public IVIewservice VIewservice
		{
			get { return _VIewservice; }
		}

		private IVIewservicegroup _VIewservicegroup;
		public IVIewservicegroup VIewservicegroup
		{
			get { return _VIewservicegroup; }
		}

		private IVIewsubmenugroup _VIewsubmenugroup;
		public IVIewsubmenugroup VIewsubmenugroup
		{
			get { return _VIewsubmenugroup; }
		}

		private IVIewsumgexpbill _VIewsumgexpbill;
		public IVIewsumgexpbill VIewsumgexpbill
		{
			get { return _VIewsumgexpbill; }
		}

		private IVIewsumgexpbillkynhan _VIewsumgexpbillkynhan;
		public IVIewsumgexpbillkynhan VIewsumgexpbillkynhan
		{
			get { return _VIewsumgexpbillkynhan; }
		}

		private IVIewsumgexpbillsanluong _VIewsumgexpbillsanluong;
		public IVIewsumgexpbillsanluong VIewsumgexpbillsanluong
		{
			get { return _VIewsumgexpbillsanluong; }
		}

		private IVIewsumgexpbillstatus _VIewsumgexpbillstatus;
		public IVIewsumgexpbillstatus VIewsumgexpbillstatus
		{
			get { return _VIewsumgexpbillstatus; }
		}

		private IVIewvckettoan _VIewvckettoan;
		public IVIewvckettoan VIewvckettoan
		{
			get { return _VIewvckettoan; }
		}

		private IVIewvckhachhang _VIewvckhachhang;
		public IVIewvckhachhang VIewvckhachhang
		{
			get { return _VIewvckhachhang; }
		}

		private IVIewvcmathang _VIewvcmathang;
		public IVIewvcmathang VIewvcmathang
		{
			get { return _VIewvcmathang; }
		}

		private IVIewvcnhacungcap _VIewvcnhacungcap;
		public IVIewvcnhacungcap VIewvcnhacungcap
		{
			get { return _VIewvcnhacungcap; }
		}

		private IVIewvihclecoupon _VIewvihclecoupon;
		public IVIewvihclecoupon VIewvihclecoupon
		{
			get { return _VIewvihclecoupon; }
		}

		private IVIewvihclecoupondetail _VIewvihclecoupondetail;
		public IVIewvihclecoupondetail VIewvihclecoupondetail
		{
			get { return _VIewvihclecoupondetail; }
		}

		private IVIewwebbannerslider _VIewwebbannerslider;
		public IVIewwebbannerslider VIewwebbannerslider
		{
			get { return _VIewwebbannerslider; }
		}

		private IVIewwebnews _VIewwebnews;
		public IVIewwebnews VIewwebnews
		{
			get { return _VIewwebnews; }
		}

		private IVIewwebpage _VIewwebpage;
		public IVIewwebpage VIewwebpage
		{
			get { return _VIewwebpage; }
		}

		private IVIhcle _VIhcle;
		public IVIhcle VIhcle
		{
			get { return _VIhcle; }
		}

		private IVIhclecoupon _VIhclecoupon;
		public IVIhclecoupon VIhclecoupon
		{
			get { return _VIhclecoupon; }
		}

		private IVIhclecoupondetail _VIhclecoupondetail;
		public IVIhclecoupondetail VIhclecoupondetail
		{
			get { return _VIhclecoupondetail; }
		}

		private IVIhcleservice _VIhcleservice;
		public IVIhcleservice VIhcleservice
		{
			get { return _VIhcleservice; }
		}

		private IVIhcleserviceconfig _VIhcleserviceconfig;
		public IVIhcleserviceconfig VIhcleserviceconfig
		{
			get { return _VIhcleserviceconfig; }
		}

		private IVOucher _VOucher;
		public IVOucher VOucher
		{
			get { return _VOucher; }
		}

		private IVPtemp _VPtemp;
		public IVPtemp VPtemp
		{
			get { return _VPtemp; }
		}

		private IVPtempr _VPtempr;
		public IVPtempr VPtempr
		{
			get { return _VPtempr; }
		}

		private IWEbbannerslider _WEbbannerslider;
		public IWEbbannerslider WEbbannerslider
		{
			get { return _WEbbannerslider; }
		}

		private IWEbbranch _WEbbranch;
		public IWEbbranch WEbbranch
		{
			get { return _WEbbranch; }
		}

		private IWEbconfig _WEbconfig;
		public IWEbconfig WEbconfig
		{
			get { return _WEbconfig; }
		}

		private IWEbemployee _WEbemployee;
		public IWEbemployee WEbemployee
		{
			get { return _WEbemployee; }
		}

		private IWEbfaq _WEbfaq;
		public IWEbfaq WEbfaq
		{
			get { return _WEbfaq; }
		}

		private IWEbfaqtopic _WEbfaqtopic;
		public IWEbfaqtopic WEbfaqtopic
		{
			get { return _WEbfaqtopic; }
		}

		private IWEbgallery _WEbgallery;
		public IWEbgallery WEbgallery
		{
			get { return _WEbgallery; }
		}

		private IWEbgalleryimage _WEbgalleryimage;
		public IWEbgalleryimage WEbgalleryimage
		{
			get { return _WEbgalleryimage; }
		}

		private IWEbicon _WEbicon;
		public IWEbicon WEbicon
		{
			get { return _WEbicon; }
		}

		private IWEbimage _WEbimage;
		public IWEbimage WEbimage
		{
			get { return _WEbimage; }
		}

		private IWEblink _WEblink;
		public IWEblink WEblink
		{
			get { return _WEblink; }
		}

		private IWEbnews _WEbnews;
		public IWEbnews WEbnews
		{
			get { return _WEbnews; }
		}

		private IWEbnewscategory _WEbnewscategory;
		public IWEbnewscategory WEbnewscategory
		{
			get { return _WEbnewscategory; }
		}

		private IWEbpage _WEbpage;
		public IWEbpage WEbpage
		{
			get { return _WEbpage; }
		}

		private IWEbpartner _WEbpartner;
		public IWEbpartner WEbpartner
		{
			get { return _WEbpartner; }
		}

		private IWEbreviews _WEbreviews;
		public IWEbreviews WEbreviews
		{
			get { return _WEbreviews; }
		}

		private IWEbsetting _WEbsetting;
		public IWEbsetting WEbsetting
		{
			get { return _WEbsetting; }
		}

		private IWEbshoping _WEbshoping;
		public IWEbshoping WEbshoping
		{
			get { return _WEbshoping; }
		}

		private IWEbshopingdetail _WEbshopingdetail;
		public IWEbshopingdetail WEbshopingdetail
		{
			get { return _WEbshopingdetail; }
		}

		/// <summary>
		/// Khởi tạo các đối tượng ánh xạ từ Database.
		/// </summary>
		private void InitContext()
		{
			this._ACcountobject = new MACcountobject(this);
			this._ACcountobjectandgroup = new MACcountobjectandgroup(this);
			this._ACcountobjectbranch = new MACcountobjectbranch(this);
			this._ACcountobjectcommission = new MACcountobjectcommission(this);
			this._ACcountobjectgroup = new MACcountobjectgroup(this);
			this._ACcountobjectimage = new MACcountobjectimage(this);
			this._ACcountobjectrewardpoint = new MACcountobjectrewardpoint(this);
			this._ACcountobjecttype = new MACcountobjecttype(this);
			this._BOoking = new MBOoking(this);
			this._BOokingdetail = new MBOokingdetail(this);
			this._BRanch = new MBRanch(this);
			this._CAshpay = new MCAshpay(this);
			this._CAshpaymoneytype = new MCAshpaymoneytype(this);
			this._CAshpaytype = new MCAshpaytype(this);
			this._COnfigbookingtime = new MCOnfigbookingtime(this);
			this._COntacthistory = new MCOntacthistory(this);
			this._DYnamicfield = new MDYnamicfield(this);
			this._DYnamicfieldtype = new MDYnamicfieldtype(this);
			this._DYnamicfilledformfields = new MDYnamicfilledformfields(this);
			this._DYnamicfilledforms = new MDYnamicfilledforms(this);
			this._DYnamicform = new MDYnamicform(this);
			this._DYnamicformfield = new MDYnamicformfield(this);
			this._EXpaccountcustomer = new MEXpaccountcustomer(this);
			this._EXpautoreport = new MEXpautoreport(this);
			this._EXpbalancedetail = new MEXpbalancedetail(this);
			this._EXpbalancedetailtype = new MEXpbalancedetailtype(this);
			this._EXpbill = new MEXpbill(this);
			this._EXpbillprocess = new MEXpbillprocess(this);
			this._EXpbillstatus = new MEXpbillstatus(this);
			this._EXpcachgiao = new MEXpcachgiao(this);
			this._EXpcachthanhtoan = new MEXpcachthanhtoan(this);
			this._EXpcalamviec = new MEXpcalamviec(this);
			this._EXpcaresale = new MEXpcaresale(this);
			this._EXpcaresalehistory = new MEXpcaresalehistory(this);
			this._EXpcashpay = new MEXpcashpay(this);
			this._EXpcheckbalance = new MEXpcheckbalance(this);
			this._EXpcheckbalancedetail = new MEXpcheckbalancedetail(this);
			this._EXpchungtu = new MEXpchungtu(this);
			this._EXpchungtuct = new MEXpchungtuct(this);
			this._EXpcodck = new MEXpcodck(this);
			this._EXpcomment = new MEXpcomment(this);
			this._EXpcommenttype = new MEXpcommenttype(this);
			this._EXpcomplainservice = new MEXpcomplainservice(this);
			this._EXpconsigndelivery = new MEXpconsigndelivery(this);
			this._EXpconsignment = new MEXpconsignment(this);
			this._EXpconsignmentcashpay = new MEXpconsignmentcashpay(this);
			this._EXpconsignmentcashpaytype = new MEXpconsignmentcashpaytype(this);
			this._EXpconsignmenthistory = new MEXpconsignmenthistory(this);
			this._EXpconsignmentobject = new MEXpconsignmentobject(this);
			this._EXpconsignmentondelivery = new MEXpconsignmentondelivery(this);
			this._EXpconsignmentqueuenumber = new MEXpconsignmentqueuenumber(this);
			this._EXpconsignmentstatus = new MEXpconsignmentstatus(this);
			this._EXpconsigntransit = new MEXpconsigntransit(this);
			this._EXpcontact = new MEXpcontact(this);
			this._EXpcontentmessage = new MEXpcontentmessage(this);
			this._EXpcost = new MEXpcost(this);
			this._EXpcustomer = new MEXpcustomer(this);
			this._EXpcustomeraccount = new MEXpcustomeraccount(this);
			this._EXpcustomergroup = new MEXpcustomergroup(this);
			this._EXpdestination = new MEXpdestination(this);
			this._EXpdistance = new MEXpdistance(this);
			this._EXpdoisoat = new MEXpdoisoat(this);
			this._EXpdoisoatchitiet = new MEXpdoisoatchitiet(this);
			this._EXpdoisoatchitietct = new MEXpdoisoatchitietct(this);
			this._EXpdonvihanhchinh = new MEXpdonvihanhchinh(this);
			this._EXpfee = new MEXpfee(this);
			this._EXpgroupfee = new MEXpgroupfee(this);
			this._EXphoadondoisoat = new MEXphoadondoisoat(this);
			this._EXphoadondoisoatkl = new MEXphoadondoisoatkl(this);
			this._EXpinternal = new MEXpinternal(this);
			this._EXpkykettoan = new MEXpkykettoan(this);
			this._EXploaimathang = new MEXploaimathang(this);
			this._EXploancod = new MEXploancod(this);
			this._EXplogerrorcheck = new MEXplogerrorcheck(this);
			this._EXploinhuanbuucuc = new MEXploinhuanbuucuc(this);
			this._EXpmistake = new MEXpmistake(this);
			this._EXpnhapkho = new MEXpnhapkho(this);
			this._EXpnhapkhoct = new MEXpnhapkhoct(this);
			this._EXpnote = new MEXpnote(this);
			this._EXpphathanhchungtu = new MEXpphathanhchungtu(this);
			this._EXppost = new MEXppost(this);
			this._EXppostaccount = new MEXppostaccount(this);
			this._EXppostfeeprovider = new MEXppostfeeprovider(this);
			this._EXpproblem = new MEXpproblem(this);
			this._EXpproviceproblem = new MEXpproviceproblem(this);
			this._EXpprovider = new MEXpprovider(this);
			this._EXpprovincefee = new MEXpprovincefee(this);
			this._EXpprovincefeecustomer = new MEXpprovincefeecustomer(this);
			this._EXprecharge = new MEXprecharge(this);
			this._EXprecheck = new MEXprecheck(this);
			this._EXpsalecongno = new MEXpsalecongno(this);
			this._EXpsaleloaithanhtoan = new MEXpsaleloaithanhtoan(this);
			this._EXpsalenhapvattu = new MEXpsalenhapvattu(this);
			this._EXpsaleproduct = new MEXpsaleproduct(this);
			this._EXpsalevattu = new MEXpsalevattu(this);
			this._EXpsalexuatkho = new MEXpsalexuatkho(this);
			this._EXpscan = new MEXpscan(this);
			this._EXpscantt = new MEXpscantt(this);
			this._EXpshipper = new MEXpshipper(this);
			this._EXpsiteautorun = new MEXpsiteautorun(this);
			this._EXptype = new MEXptype(this);
			this._EXpwithdrawal = new MEXpwithdrawal(this);
			this._EXpwithdrawrequest = new MEXpwithdrawrequest(this);
			this._EXpwithdrawrequeststatus = new MEXpwithdrawrequeststatus(this);
			this._EXpwithdrawrequesttype = new MEXpwithdrawrequesttype(this);
			this._GExpaccept = new MGExpaccept(this);
			this._GExpautosign = new MGExpautosign(this);
			this._GExpbalancedetail = new MGExpbalancedetail(this);
			this._GExpbalancedetailpost = new MGExpbalancedetailpost(this);
			this._GExpbalancedetailtype = new MGExpbalancedetailtype(this);
			this._GExpbankemail = new MGExpbankemail(this);
			this._GExpbankvp = new MGExpbankvp(this);
			this._GExpbill = new MGExpbill(this);
			this._GExpbillhistory = new MGExpbillhistory(this);
			this._GExpbillstatus = new MGExpbillstatus(this);
			this._GExpbillstatusname = new MGExpbillstatusname(this);
			this._GExpcode = new MGExpcode(this);
			this._GExpdebitcomparison = new MGExpdebitcomparison(this);
			this._GExpdebitcomparisondetail = new MGExpdebitcomparisondetail(this);
			this._GExpdebitsession = new MGExpdebitsession(this);
			this._GExpdebitsessiondetail = new MGExpdebitsessiondetail(this);
			this._GExpdistrict = new MGExpdistrict(this);
			this._GExpdistrictbamboo = new MGExpdistrictbamboo(this);
			this._GExpdistrictghsv = new MGExpdistrictghsv(this);
			this._GExpdistrictjnt = new MGExpdistrictjnt(this);
			this._GExpdistrictvn = new MGExpdistrictvn(this);
			this._GExpdistrictvnp = new MGExpdistrictvnp(this);
			this._GExpdistrictvtp = new MGExpdistrictvtp(this);
			this._GExpdoisoat = new MGExpdoisoat(this);
			this._GExpdoisoatchitiet = new MGExpdoisoatchitiet(this);
			this._GExpdoisoatchitietct = new MGExpdoisoatchitietct(this);
			this._GExpdoisoathistory = new MGExpdoisoathistory(this);
			this._GExperror = new MGExperror(this);
			this._GExpfee = new MGExpfee(this);
			this._GExpfeedebitsession = new MGExpfeedebitsession(this);
			this._GExpfeedetail = new MGExpfeedetail(this);
			this._GExpfeemaster = new MGExpfeemaster(this);
			this._GExpfeeprovincedetail = new MGExpfeeprovincedetail(this);
			this._GExpmoneyreturn = new MGExpmoneyreturn(this);
			this._GExpmoneyreturnsession = new MGExpmoneyreturnsession(this);
			this._GExpmoneyreturnstatus = new MGExpmoneyreturnstatus(this);
			this._GExpnotification = new MGExpnotification(this);
			this._GExporder = new MGExporder(this);
			this._GExporderstatus = new MGExporderstatus(this);
			this._GExppaymenttype = new MGExppaymenttype(this);
			this._GExpproblem = new MGExpproblem(this);
			this._GExpprofit = new MGExpprofit(this);
			this._GExpprovider = new MGExpprovider(this);
			this._GExpproviderconfig = new MGExpproviderconfig(this);
			this._GExpprovidercustomer = new MGExpprovidercustomer(this);
			this._GExpprovidersub = new MGExpprovidersub(this);
			this._GExpprovidertype = new MGExpprovidertype(this);
			this._GExpprovince = new MGExpprovince(this);
			this._GExpprovincebamboo = new MGExpprovincebamboo(this);
			this._GExpprovincefeez = new MGExpprovincefeez(this);
			this._GExpprovinceghsv = new MGExpprovinceghsv(this);
			this._GExpprovincejnt = new MGExpprovincejnt(this);
			this._GExpprovincevn = new MGExpprovincevn(this);
			this._GExpprovincevnp = new MGExpprovincevnp(this);
			this._GExpprovincevtp = new MGExpprovincevtp(this);
			this._GExpreceivetask = new MGExpreceivetask(this);
			this._GExpreceivetaskstatus = new MGExpreceivetaskstatus(this);
			this._GExprequestmoney = new MGExprequestmoney(this);
			this._GExpscan = new MGExpscan(this);
			this._GExpscancome = new MGExpscancome(this);
			this._GExpscandelivery = new MGExpscandelivery(this);
			this._GExpscanreceive = new MGExpscanreceive(this);
			this._GExpscanreturn = new MGExpscanreturn(this);
			this._GExpscansend = new MGExpscansend(this);
			this._GExpscansign = new MGExpscansign(this);
			this._GExpscantype = new MGExpscantype(this);
			this._GExpsender = new MGExpsender(this);
			this._GExpshipnotetype = new MGExpshipnotetype(this);
			this._GExpshipper = new MGExpshipper(this);
			this._GExpshipperbillstatus = new MGExpshipperbillstatus(this);
			this._GExpshippercash = new MGExpshippercash(this);
			this._GExpshippercashdetail = new MGExpshippercashdetail(this);
			this._GExpshipperdevivery = new MGExpshipperdevivery(this);
			this._GExpward = new MGExpward(this);
			this._GExpwardbamboo = new MGExpwardbamboo(this);
			this._GExpwardghsv = new MGExpwardghsv(this);
			this._GExpwardjnt = new MGExpwardjnt(this);
			this._GExpwardvn = new MGExpwardvn(this);
			this._GExpwardvnp = new MGExpwardvnp(this);
			this._GExpwardvtp = new MGExpwardvtp(this);
			this._GExpwebhook = new MGExpwebhook(this);
			this._GExpwebhookport = new MGExpwebhookport(this);
			this._GExpwithdrawmoney = new MGExpwithdrawmoney(this);
			this._GSbank = new MGSbank(this);
			this._GScategory = new MGScategory(this);
			this._GSccy = new MGSccy(this);
			this._GScountry = new MGScountry(this);
			this._GScustomeroder = new MGScustomeroder(this);
			this._GSkpiaccounttarget = new MGSkpiaccounttarget(this);
			this._GSkpiaccounttargetruntime = new MGSkpiaccounttargetruntime(this);
			this._GSkpitarget = new MGSkpitarget(this);
			this._GSkpitargettype = new MGSkpitargettype(this);
			this._GSport = new MGSport(this);
			this._GSrequestfindproduct = new MGSrequestfindproduct(this);
			this._GSrequestfindproducthistory = new MGSrequestfindproducthistory(this);
			this._GSrequestinstance = new MGSrequestinstance(this);
			this._GSstepdef = new MGSstepdef(this);
			this._GSsteprequestfindproduct = new MGSsteprequestfindproduct(this);
			this._GSunit = new MGSunit(this);
			this._GSworkflowdef = new MGSworkflowdef(this);
			this._INventory = new MINventory(this);
			this._INvoice = new MINvoice(this);
			this._INvoicedetail = new MINvoicedetail(this);
			this._MAmnonclass = new MMAmnonclass(this);
			this._MAmnonclasshocvien = new MMAmnonclasshocvien(this);
			this._MAmnondiemdanh = new MMAmnondiemdanh(this);
			this._MAmnonhocvien = new MMAmnonhocvien(this);
			this._MAmnonsodaubai = new MMAmnonsodaubai(this);
			this._MAmnonthangdiem = new MMAmnonthangdiem(this);
			this._MAmnonthuhocphi = new MMAmnonthuhocphi(this);
			this._MAmnontruonghoc = new MMAmnontruonghoc(this);
			this._MEdbacsicdha = new MMEdbacsicdha(this);
			this._MEdbenhnhan = new MMEdbenhnhan(this);
			this._MEdcapmaso = new MMEdcapmaso(this);
			this._MEdchidinh = new MMEdchidinh(this);
			this._MEdchidinhsync = new MMEdchidinhsync(this);
			this._MEdcoso = new MMEdcoso(this);
			this._MEdcotbaocao = new MMEdcotbaocao(this);
			this._MEddmdonvi = new MMEddmdonvi(this);
			this._MEddmketqua = new MMEddmketqua(this);
			this._MEddmmay = new MMEddmmay(this);
			this._MEddmso = new MMEddmso(this);
			this._MEddmten = new MMEddmten(this);
			this._MEdgiavp = new MMEdgiavp(this);
			this._MEdhistory = new MMEdhistory(this);
			this._MEdhistoryct = new MMEdhistoryct(this);
			this._MEdhosonhanbenh = new MMEdhosonhanbenh(this);
			this._MEdketluanmau = new MMEdketluanmau(this);
			this._MEdketqua = new MMEdketqua(this);
			this._MEdketquaautotext = new MMEdketquaautotext(this);
			this._MEdketquachandoan = new MMEdketquachandoan(this);
			this._MEdketquachandoanha = new MMEdketquachandoanha(this);
			this._MEdketquact = new MMEdketquact(this);
			this._MEdketquadcm = new MMEdketquadcm(this);
			this._MEdketquaecg = new MMEdketquaecg(this);
			this._MEdketquamacdinh = new MMEdketquamacdinh(this);
			this._MEdketquamayxn = new MMEdketquamayxn(this);
			this._MEdketquaxn = new MMEdketquaxn(this);
			this._MEdkhoaphong = new MMEdkhoaphong(this);
			this._MEdlaymau = new MMEdlaymau(this);
			this._MEdlaymauct = new MMEdlaymauct(this);
			this._MEdloaikhoaphong = new MMEdloaikhoaphong(this);
			this._MEdloaivp = new MMEdloaivp(this);
			this._MEdlogin = new MMEdlogin(this);
			this._MEdmaso = new MMEdmaso(this);
			this._MEdmauin = new MMEdmauin(this);
			this._MEdmauketqua = new MMEdmauketqua(this);
			this._MEdmayxn = new MMEdmayxn(this);
			this._MEdnhombenhnhan = new MMEdnhombenhnhan(this);
			this._MEdnhomvp = new MMEdnhomvp(this);
			this._MEdphieunhanbenh = new MMEdphieunhanbenh(this);
			this._MEdphieunhanbenhchitiet = new MMEdphieunhanbenhchitiet(this);
			this._MEdserver = new MMEdserver(this);
			this._MEdsetting = new MMEdsetting(this);
			this._MEdsomauxetnghiem = new MMEdsomauxetnghiem(this);
			this._MEdthongsokqmayxn = new MMEdthongsokqmayxn(this);
			this._MEdticcapmaso = new MMEdticcapmaso(this);
			this._MEdworkspace = new MMEdworkspace(this);
			this._MEdxnloai = new MMEdxnloai(this);
			this._MEdxnloaimay = new MMEdxnloaimay(this);
			this._MEdxnten = new MMEdxnten(this);
			this._MEdxnthongsomay = new MMEdxnthongsomay(this);
			this._MEdxnthongsomayct = new MMEdxnthongsomayct(this);
			this._MEnufunction = new MMEnufunction(this);
			this._MEnufunctionaccount = new MMEnufunctionaccount(this);
			this._MEnufunctionrole = new MMEnufunctionrole(this);
			this._MEnufunctiongroup = new MMEnufunctiongroup(this);
			this._MEnuimage = new MMEnuimage(this);
			this._MEnurole = new MMEnurole(this);
			this._MEnuroleaccountobject = new MMEnuroleaccountobject(this);
			this._PRoductquota = new MPRoductquota(this);
			this._QUeuenumber = new MQUeuenumber(this);
			this._ROom = new MROom(this);
			this._ROomgroup = new MROomgroup(this);
			this._SAlebalancedetail = new MSAlebalancedetail(this);
			this._SAlebanggia = new MSAlebanggia(this);
			this._SAlebanggiachitiet = new MSAlebanggiachitiet(this);
			this._SAlehoadon = new MSAlehoadon(this);
			this._SAlehoadonchitiet = new MSAlehoadonchitiet(this);
			this._SAlekhachhang = new MSAlekhachhang(this);
			this._SAlenhomsanpham = new MSAlenhomsanpham(this);
			this._SAlesanpham = new MSAlesanpham(this);
			this._SChoolcapbac = new MSChoolcapbac(this);
			this._SChoolgiaotrinh = new MSChoolgiaotrinh(this);
			this._SChoolgiaotrinhhocphan = new MSChoolgiaotrinhhocphan(this);
			this._SChoolhocphan = new MSChoolhocphan(this);
			this._SChoolhocvien = new MSChoolhocvien(this);
			this._SChoolphonggiaoduc = new MSChoolphonggiaoduc(this);
			this._SChoolprogram = new MSChoolprogram(this);
			this._SChoolroom = new MSChoolroom(this);
			this._SChoolsogiaoduc = new MSChoolsogiaoduc(this);
			this._SChooltrungtamav = new MSChooltrungtamav(this);
			this._SErvice = new MSErvice(this);
			this._SErvicecombo = new MSErvicecombo(this);
			this._SErvicegroup = new MSErvicegroup(this);
			this._SErviceimage = new MSErviceimage(this);
			this._SEtting = new MSEtting(this);
			this._SEttingbranch = new MSEttingbranch(this);
			this._STock = new MSTock(this);
			this._STockimportexport = new MSTockimportexport(this);
			this._STockimportexportdetail = new MSTockimportexportdetail(this);
			this._SYsdiagrams = new MSYsdiagrams(this);
			this._TAskactionhistory = new MTAskactionhistory(this);
			this._TAskissue = new MTAskissue(this);
			this._TAskissuepriority = new MTAskissuepriority(this);
			this._TAskissuestatus = new MTAskissuestatus(this);
			this._TAskissuetracker = new MTAskissuetracker(this);
			this._VCkettoan = new MVCkettoan(this);
			this._VCkhachhang = new MVCkhachhang(this);
			this._VCloaichiphi = new MVCloaichiphi(this);
			this._VCmathang = new MVCmathang(this);
			this._VCnhacungcap = new MVCnhacungcap(this);
			this._VCnhaphang = new MVCnhaphang(this);
			this._VCxuathang = new MVCxuathang(this);
			this._VIewaccountobject = new MVIewaccountobject(this);
			this._VIewautosigndelivery = new MVIewautosigndelivery(this);
			this._VIewbaocaotaichinh = new MVIewbaocaotaichinh(this);
			this._VIewbooking = new MVIewbooking(this);
			this._VIewbranch = new MVIewbranch(this);
			this._VIewcashpay = new MVIewcashpay(this);
			this._VIewdoisoatchitiet = new MVIewdoisoatchitiet(this);
			this._VIewexpbill = new MVIewexpbill(this);
			this._VIewexpbillhoadondoisoat = new MVIewexpbillhoadondoisoat(this);
			this._VIewexpcashpay = new MVIewexpcashpay(this);
			this._VIewexpchungtu = new MVIewexpchungtu(this);
			this._VIewexpchungtuct = new MVIewexpchungtuct(this);
			this._VIewexpchungtuctreport = new MVIewexpchungtuctreport(this);
			this._VIewexpchungtuphieuchi = new MVIewexpchungtuphieuchi(this);
			this._VIewexpcodck = new MVIewexpcodck(this);
			this._VIewexpcomment = new MVIewexpcomment(this);
			this._VIewexpconsigndelivery = new MVIewexpconsigndelivery(this);
			this._VIewexpconsignment = new MVIewexpconsignment(this);
			this._VIewexpconsignmentcashpay = new MVIewexpconsignmentcashpay(this);
			this._VIewexpconsignmenthistory = new MVIewexpconsignmenthistory(this);
			this._VIewexpconsignmenthistorymater = new MVIewexpconsignmenthistorymater(this);
			this._VIewexpconsignmentobject = new MVIewexpconsignmentobject(this);
			this._VIewexpconsigntransit = new MVIewexpconsigntransit(this);
			this._VIewexpcustomer = new MVIewexpcustomer(this);
			this._VIewexpcustomergroup = new MVIewexpcustomergroup(this);
			this._VIewexpdvhchuyen = new MVIewexpdvhchuyen(this);
			this._VIewexpdvhctinh = new MVIewexpdvhctinh(this);
			this._VIewexpdvhcxa = new MVIewexpdvhcxa(this);
			this._VIewexpkykettoan = new MVIewexpkykettoan(this);
			this._VIewexploancod = new MVIewexploancod(this);
			this._VIewexpnhapkho = new MVIewexpnhapkho(this);
			this._VIewexpnhapkhoct = new MVIewexpnhapkhoct(this);
			this._VIewexppost = new MVIewexppost(this);
			this._VIewexpproviceproblem = new MVIewexpproviceproblem(this);
			this._VIewexprecharge = new MVIewexprecharge(this);
			this._VIewexpsalenhapvattu = new MVIewexpsalenhapvattu(this);
			this._VIewexpsalexuatkho = new MVIewexpsalexuatkho(this);
			this._VIewexptotalchungtu = new MVIewexptotalchungtu(this);
			this._VIewexpwithdrawrequest = new MVIewexpwithdrawrequest(this);
			this._VIewgexpautosign = new MVIewgexpautosign(this);
			this._VIewgexpbalancedetail = new MVIewgexpbalancedetail(this);
			this._VIewgexpbalancedetailpost = new MVIewgexpbalancedetailpost(this);
			this._VIewgexpbill = new MVIewgexpbill(this);
			this._VIewgexpbillcus = new MVIewgexpbillcus(this);
			this._VIewgexpbilldelivery = new MVIewgexpbilldelivery(this);
			this._VIewgexpbillghn = new MVIewgexpbillghn(this);
			this._VIewgexpbillghnapi = new MVIewgexpbillghnapi(this);
			this._VIewgexpbillhistory = new MVIewgexpbillhistory(this);
			this._VIewgexpbillmaster = new MVIewgexpbillmaster(this);
			this._VIewgexpdebitcomparison = new MVIewgexpdebitcomparison(this);
			this._VIewgexpdebitcomparisondetail = new MVIewgexpdebitcomparisondetail(this);
			this._VIewgexpdoisoatchitiet = new MVIewgexpdoisoatchitiet(this);
			this._VIewgexpfee = new MVIewgexpfee(this);
			this._VIewgexpfeedebitsession = new MVIewgexpfeedebitsession(this);
			this._VIewgexpfeedetails = new MVIewgexpfeedetails(this);
			this._VIewgexpfeedetailspro = new MVIewgexpfeedetailspro(this);
			this._VIewgexpmoneyreturn = new MVIewgexpmoneyreturn(this);
			this._VIewgexpmoneyreturnsession = new MVIewgexpmoneyreturnsession(this);
			this._VIewgexpnotification = new MVIewgexpnotification(this);
			this._VIewgexporder = new MVIewgexporder(this);
			this._VIewgexpproblem = new MVIewgexpproblem(this);
			this._VIewgexpprovider = new MVIewgexpprovider(this);
			this._VIewgexpreceivetask = new MVIewgexpreceivetask(this);
			this._VIewgexprequestmoney = new MVIewgexprequestmoney(this);
			this._VIewgexpscan = new MVIewgexpscan(this);
			this._VIewgexpscancome = new MVIewgexpscancome(this);
			this._VIewgexpscandelivery = new MVIewgexpscandelivery(this);
			this._VIewgexpscanreturn = new MVIewgexpscanreturn(this);
			this._VIewgexpscansend = new MVIewgexpscansend(this);
			this._VIewgexpscansign = new MVIewgexpscansign(this);
			this._VIewgexpshipper = new MVIewgexpshipper(this);
			this._VIewgexpshippercash = new MVIewgexpshippercash(this);
			this._VIewgexpshippercashdetail = new MVIewgexpshippercashdetail(this);
			this._VIewgexpshipperdevivery = new MVIewgexpshipperdevivery(this);
			this._VIewgexpwithdrawmoney = new MVIewgexpwithdrawmoney(this);
			this._VIewinvoicelist = new MVIewinvoicelist(this);
			this._VIewinvoiceprint = new MVIewinvoiceprint(this);
			this._VIewmamnontruonghoc = new MVIewmamnontruonghoc(this);
			this._VIewmenufunction = new MVIewmenufunction(this);
			this._VIewmenufunctionaccount = new MVIewmenufunctionaccount(this);
			this._VIewrole = new MVIewrole(this);
			this._VIewroom = new MVIewroom(this);
			this._VIewroomgroup = new MVIewroomgroup(this);
			this._VIewschoolgiaotrinh = new MVIewschoolgiaotrinh(this);
			this._VIewschoolgiaotrinhhocphan = new MVIewschoolgiaotrinhhocphan(this);
			this._VIewschoolhocphan = new MVIewschoolhocphan(this);
			this._VIewschoolphonggiaoduc = new MVIewschoolphonggiaoduc(this);
			this._VIewschoolprogram = new MVIewschoolprogram(this);
			this._VIewschoolroom = new MVIewschoolroom(this);
			this._VIewschoolsogiaoduc = new MVIewschoolsogiaoduc(this);
			this._VIewschooltrungtamav = new MVIewschooltrungtamav(this);
			this._VIewservice = new MVIewservice(this);
			this._VIewservicegroup = new MVIewservicegroup(this);
			this._VIewsubmenugroup = new MVIewsubmenugroup(this);
			this._VIewsumgexpbill = new MVIewsumgexpbill(this);
			this._VIewsumgexpbillkynhan = new MVIewsumgexpbillkynhan(this);
			this._VIewsumgexpbillsanluong = new MVIewsumgexpbillsanluong(this);
			this._VIewsumgexpbillstatus = new MVIewsumgexpbillstatus(this);
			this._VIewvckettoan = new MVIewvckettoan(this);
			this._VIewvckhachhang = new MVIewvckhachhang(this);
			this._VIewvcmathang = new MVIewvcmathang(this);
			this._VIewvcnhacungcap = new MVIewvcnhacungcap(this);
			this._VIewvihclecoupon = new MVIewvihclecoupon(this);
			this._VIewvihclecoupondetail = new MVIewvihclecoupondetail(this);
			this._VIewwebbannerslider = new MVIewwebbannerslider(this);
			this._VIewwebnews = new MVIewwebnews(this);
			this._VIewwebpage = new MVIewwebpage(this);
			this._VIhcle = new MVIhcle(this);
			this._VIhclecoupon = new MVIhclecoupon(this);
			this._VIhclecoupondetail = new MVIhclecoupondetail(this);
			this._VIhcleservice = new MVIhcleservice(this);
			this._VIhcleserviceconfig = new MVIhcleserviceconfig(this);
			this._VOucher = new MVOucher(this);
			this._VPtemp = new MVPtemp(this);
			this._VPtempr = new MVPtempr(this);
			this._WEbbannerslider = new MWEbbannerslider(this);
			this._WEbbranch = new MWEbbranch(this);
			this._WEbconfig = new MWEbconfig(this);
			this._WEbemployee = new MWEbemployee(this);
			this._WEbfaq = new MWEbfaq(this);
			this._WEbfaqtopic = new MWEbfaqtopic(this);
			this._WEbgallery = new MWEbgallery(this);
			this._WEbgalleryimage = new MWEbgalleryimage(this);
			this._WEbicon = new MWEbicon(this);
			this._WEbimage = new MWEbimage(this);
			this._WEblink = new MWEblink(this);
			this._WEbnews = new MWEbnews(this);
			this._WEbnewscategory = new MWEbnewscategory(this);
			this._WEbpage = new MWEbpage(this);
			this._WEbpartner = new MWEbpartner(this);
			this._WEbreviews = new MWEbreviews(this);
			this._WEbsetting = new MWEbsetting(this);
			this._WEbshoping = new MWEbshoping(this);
			this._WEbshopingdetail = new MWEbshopingdetail(this);
		}

	}
}
