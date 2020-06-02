WITH
cte as 
(
select
CASE 
WHEN dpav.isprimary = 1
THEN ct.accountnum
ELSE concat (ct.accountnum,'_',dpav.zipcode) 
END 'Customeraccount',
'Yes' as 'ax',
CASE
WHEN isct.NAMEALIAS like '%DO NOT USE%'
THEN '1'
ELSE ''
END 'Archived',
CASE 
WHEN ct.INVOICEACCOUNT = ct.ACCOUNTNUM 

THEN ''

ELSE CT.INVOICEACCOUNT
END 'KeyAccountCode',
isnull (t13.[DeliveryAddresses], '') DeliveryAddress,
isnull (t13.[DeliveryAddresses], '') DeliveryAddress2,

case 
when DeliveryAddresses <> '' or ct.INVOICEACCOUNT = '' then 'Yes' 
--when DeliveryAddresses <> '' or ct.INVOICEACCOUNT = '' and Customeraccount LIKE '%[_]%' 
else 'No'
end 'KeyAccount',

isct.NAME as 'Name',
isct.NAMEALIAS 'Search name',
dpav.ZIPCODE as 'ZIPCODE',
dpav.CITY as 'CITY',
UPPER(dpav.COUNTRYREGIONID) as 'COUNTRYREGIOID',
replace(replace(dpav.STREET,CHAR(13),''),CHAR(10),'') as 'STREET',
isnull(lea.LOCATOR,'') as 'Telephone',
isnull(lea.LOCATOREXTENSION,'') as 'Extension',
ct.CURRENCY as 'CURRENCY',
ct.CUSTGROUP as 'Customer group',
ct.INVOICEACCOUNT as 'Invoice account',
ct.CREATEDDATETIME as 'Created date and time',
ct.CREATEDBY as 'Created by',
ct.VATNUMBER_BG as 'VAT number',
dpav.COUNTRYREGIONID as'Country region',
dpav.COUNTRYREGIONID as'AccessRights',
cast ((concat(crm.CountryGroupId,',69')) as nvarchar (10)) as 'GroupID'


from custtable ct

left join DIRPARTYPOSTALADDRESSVIEW dpav
on ct.PARTY = dpav.PARTY


left join IS_CUSTTABLEVIEW ISCT
on 
ct.DATAAREAID = ISCT.DATAAREAID and
ct.ACCOUNTNUM = ISCT.ACCOUNTNUM

left join dbo.DIRPARTYTABLE dpt
on ct.PARTY = dpt.RECID

left join
dbo.LOGISTICSELECTRONICADDRESS lea
on dpt.PRIMARYCONTACTPHONE = lea.RECID

left join
dbo.Z_crmnv_CountryGroups crm
on dpav.COUNTRYREGIONID = crm.CountryGroupName

left join
(select 
llp.party,lpa.MODIFIEDDATETIME, lpa.VALIDTO,lpa.RECID from LOGISTICSPOSTALADDRESS lpa
left join LOGISTICSLOCATIONPARTY llp
on lpa.LOCATION = llp.LOCATION
group by llp.party,lpa.RECID ,lpa.MODIFIEDDATETIME, lpa.VALIDTO
having max(lpa.VALIDTO) > CURRENT_TIMESTAMP) lpa2
on ct.PARTY = lpa2.PARTY


left join 
(select
c1.INVOICEACCOUNT as [KeyAccountCode],
STUFF(
(SELECT ',' + c2.ACCOUNTNUM FROM CUSTTABLE c2 where c2.INVOICEACCOUNT = c1.INVOICEACCOUNT and c2.dataareaid = '110' FOR XML PATH ('')), 1, 1, ''
) as [DeliveryAddresses] 
from dbo.CUSTTABLE c1
where c1.INVOICEACCOUNT <> '' and c1.ACCOUNTNUM <> c1.INVOICEACCOUNT and DATAAREAID = '110'
group by c1.INVOICEACCOUNT) t13
on t13.[KeyAccountCode] = ct.ACCOUNTNUM 

where
ct.DATAAREAID = '110'
and isct.NAME <> 'Import Customer Sales'
-- and isct.NAMEALIAS not like '%DO NOT USE%'
and ZIPCODE <> ''
-- and (CONVERT(VARCHAR(10),ct.MODIFIEDDATETIME,110) >= DATEADD(day,-5,GETDATE())
-- or CONVERT(VARCHAR(10),dpt.MODIFIEDDATETIME,110) >= DATEADD(day,-5,GETDATE())
-- or CONVERT(VARCHAR(10),lpa2.MODIFIEDDATETIME,110) >= DATEADD(day,-5,GETDATE()))
--and isct.NAME = 'Trouw Nutrition Espana SA'



group by ct.party,dpav.isprimary,ct.ACCOUNTNUM,dpav.LOCATION,isct.NAME, dpt.MODIFIEDDATETIME,
isct.NAMEALIAS, dpav.ZIPCODE,dpav.CITY,dpav.COUNTRYREGIONID,dpav.STREET,
ct.CUSTNAME_BG, lea.LOCATOR, lea.LOCATOREXTENSION, ct.CURRENCY, ct.CUSTGROUP,
ct.INVOICEACCOUNT, ct.CREATEDDATETIME, ct.CREATEDBY, ct.VATNUMBER_BG, dpav.COUNTRYREGIONID,
dpav.COUNTRYREGIONID, crm.CountryGroupId
,t13.[DeliveryAddresses]
,t13.[KeyAccountCode]

having max(dpav.VALIDTO) > CURRENT_TIMESTAMP

--order by Customeraccount
)
--select cte.DeliveryAddress,* from cte

select
cte.Customeraccount,
cte.ax,
cte.Archived,
cte.KeyAccountCode,
cte.DeliveryAddress,
cte.DeliveryAddress2,
case 
when (cte.DeliveryAddress <> '' or cte.[Invoice account] = '') and cte.Customeraccount LIKE '%[_]%' then 'No'
when cte.DeliveryAddress <> '' then 'Yes' 
else 'No'
end 'KeyAccount',
cte.[Invoice account],
cte.Name,
cte.[Search name],
cte.ZIPCODE,
cte.CITY,
cte.COUNTRYREGIOID,
cte.STREET,
cte.Telephone,
cte.Extension,
cte.CURRENCY,
cte.[Customer group],
cte.[Invoice account],
cte.[Created date and time],
cte.[Created by],
cte.[VAT number],
cte.[Country region],
cte.AccessRights,
cte.GroupID
from cte
order by cte.Customeraccount



