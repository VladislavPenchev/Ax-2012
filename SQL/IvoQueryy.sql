SELECT VALUE,* FROM MARKUPAUTOLINE


SELECT 
(case when mt.ACCOUNTCODE = 0 then 'Table'
	  when mt.ACCOUNTCODE = 1 then 'Group'
	  when mt.ACCOUNTCODE = 2 then 'All' 
	         else NULL
             end) as ACCOUNTCODE,
mt.ACCOUNTRELATION,
(case when mt.ITEMCODE = 0 then 'Table'
	  when mt.ITEMCODE = 1 then 'Group'
	  when mt.ITEMCODE = 2 then 'All' 
	         else NULL
             end) as ITEMCODE,
mt.ITEMRELATION,
ml.CURRENCYCODE,
ml.MARKUPCODE,
(case when ml.MARKUPCATEGORY = 0 then 'Fixed'
	  when ml.MARKUPCATEGORY = 1 then 'Psc.'
	  when ml.MARKUPCATEGORY = 2 then 'Percent'
	  when ml.MARKUPCATEGORY = 3 then 'Intercompany percent' 
	  when ml.MARKUPCATEGORY = 4 then 'External' 
	         else NULL
             end) as MARKUPCATEGORY,
ml.VALUE
FROM MARKUPAUTOTABLE mt
INNER JOIN MARKUPAUTOLINE ml
ON mt.RECID = ml.RECID
AND mt.PARTITION = ml.PARTITION
AND mt.DATAAREAID = ml.DATAAREAID