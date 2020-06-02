CREATE VIEW VQ9 AS 

With
cte as 
(
	select 
		g.ISCREDIT, 
		g.POSTINGTYPE, 
		a.SUBLEDGERVOUCHERDATAAREAID, 
		g.LEDGERDIMENSION,	   
		a.ACCOUNTINGDATE,
		a.Postinglayer,
		d.DISPLAYVALUE, 
		da.NAME, 
		g.recid, 
		a.SUBLEDGERVOUCHER,
		g.ACCOUNTINGCURRENCYAMOUNT  
	from 
		GeneralJournalAccountEntry g 
	inner join 
		DimensionAttributeLevelValueAllView d on d.ValueCombinationRecId = g.LEDGERDIMENSION	   
	left outer join 
		DIMENSIONATTRIBUTEVALUE dv on d.ATTRIBUTEVALUERECID = dv.RECID
	left outer join 
		DIMENSIONATTRIBUTE da on dv.DIMENSIONATTRIBUTE = da.recid
	left join 
		GeneralJournalEntry a on a.RECID = g.GENERALJOURNALENTRY
where
	a.ACCOUNTINGDATE >= '2017-01-01' 
	and a.POSTINGLAYER <> '2' 
	--and da.NAME = 'Vendor'
	--and GENERALJOURNALENTRY = 5637166739
	
)

select z.*
,vc.NAME
from
(
select 
	case when max(cte.ISCREDIT)=1 then 'Credit' else 'Debit' end as Type,
	max(cte.LEDGERDIMENSION) as dim,
	max(cte.POSTINGTYPE) as PostingType,
	max(cte.SUBLEDGERVOUCHERDATAAREAID) as DataAreaID,
	max(cte.ACCOUNTINGDATE) as AccountingDate,
	max(cte.SUBLEDGERVOUCHER) as 'Voucher',
	cte.recid as 'GeneralJournalAccEntry.Recid',
	max(case name when 'MainAccount' then COALESCE(displayvalue,'') else '' end) as 'MainAccount',			
	max(case name when 'Vendor' then COALESCE(displayvalue,'') else '' end) as 'Vendor',
	max(cte.ACCOUNTINGCURRENCYAMOUNT) as Amount,
	max(cte.postinglayer) as postinglayer
from 
	cte 
where cte.POSTINGTYPE <> '19'
--and cte.SUBLEDGERVOUCHER = '2PI1700116'
--OR cte.SUBLEDGERVOUCHER = '2PI1700117'
--and cte.NAME = 'vendor'

group by cte.recid 

) z
left join 	VENDTABLECUBE vc on z.Vendor = vc.ACCOUNTNUM

GO

/*
			//ONLY FOR ONE//
SELECT *,
		CASE
			WHEN Vendor = ''
			THEN (SELECT TOP(1) Vendor FROM VQ5 WHERE Vendor <> '')
			ELSE (SELECT TOP(1) Vendor FROM VQ5 WHERE Vendor <> '')
	   END AS RES
FROM VQ5

*/

SELECT 
	Type,
	DIM,
	PostingType,
	DataAreaID,
	AccountingDate,
	Voucher,
	'GeneralJournalAccEntry.Recid',
	MainAccount,
	max(Vendor) over (partition by Voucher) AS Vendor,
	Amount,
	postinglayer,
	name
FROM VQ9






