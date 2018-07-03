SELECT PURCHID,* FROM PURCHPARMTABLE WHERE PURCHID = 'PO037180' AND DATAAREAID = '410'

SELECT * FROM PURCHTABLE WHERE PURCHID = 'PO037180' AND DATAAREAID = '410'

/*
            _purchLine.clear();
            _purchTable.InterCompanyOrigin = 0;
            _purchTable.InterCompanyCompanyId = "";
            _purchTable.InterCompanySalesId = "";
            _purchTable.InterCompanyOrder = 0;
            _purchTable.update();
*/


SELECT
INTERCOMPANYORIGIN,
INTERCOMPANYCOMPANYID,
INTERCOMPANYSALESID,
INTERCOMPANYORDER
,* 
FROM PURCHTABLE 
WHERE PURCHID = 'PO037180' AND DATAAREAID = '410'




SELECT * FROM PurchPurchaseOrderHeader