--SELECT (LEN(PURCHID) - LEN(REPLACE(PURCHID,'0',''))),* FROM PURCHTABLE WHERE PURCHID = 'PO-0000001'

--SELECT PURCHID FROM PURCHTABLE CROSS APPLY STRING_SPLIT()


CREATE FUNCTION dbo.splitstringsss ( @stringToSplit VARCHAR(MAX) )
RETURNS
 @returnList TABLE ([Name] [nvarchar] (500))
AS
BEGIN

 DECLARE @name NVARCHAR(255)
 DECLARE @pos INT

 WHILE CHARINDEX('@', @stringToSplit) > 0
 BEGIN
  SELECT @pos  = CHARINDEX('@', @stringToSplit)  
  SELECT @name = SUBSTRING(@stringToSplit, 1, @pos-1)

  INSERT INTO @returnList 
  SELECT @name

  SELECT @stringToSplit = SUBSTRING(@stringToSplit, @pos+1, LEN(@stringToSplit)-@pos)
 END

 INSERT INTO @returnList
 SELECT @stringToSplit

 RETURN
END
GO
--CREATE TABLE
CREATE TABLE PERSON_TEST(
	PersonName varchar(255));
Go

SELECT * FROM PERSON_TEST

SELECT *  FROM dbo.splitstringsss('ivano.ceresa@ometitalia.it') WHERE Name = 'ivano.ceresa'
GO


INSERT INTO PERSON_TEST(PersonName) 
	VALUES
((SELECT *  FROM dbo.splitstringsss('ivano.ceresa@ometitalia.it') WHERE Name = 'ivano.ceresa'))


declare @list as varchar(8000)
set @list += @list (SELECT *  FROM dbo.splitstringsss('ivano.ceresa@ometitalia.it') WHERE Name = 'ivano.ceresa')

--declare @list as varchar(8000)


INSERT INTO PURCHTABLE(EMAIL) 
	VALUES
(@list)
