
SELECT * FROM securityuserrole WHERE USER_ = 'axtest'

SELECT SECURITYROLE,* FROM OMUserRoleOrganization

DELETE FROM OMUserRoleOrganization WHERE USER_='bc2012'


SELECT * FROM SecurityRole where RECID = '886356' --  vsichki roli 
SELECT * FROM SecurityUserRole WHERE USER_ = 'bc2012'   -- koi kakva rolq ima 



SELECT * FROM SECURITYUSERROLECONDITION
SELECT * FROM SECURITYSEGREGATIONOFDUTIESCONFLICT.
SELECT RECID,* FROM USERINFO WHERE ID = 'axtest'


SELECT * FROM SecurityUserRoleCondition 
left join SECURITYUSERROLE
ON SECURITYUSERROLECONDITION.SECURITYUSERROLE = securityuserrole.RECID
WHERE SECURITYUSERROLE.USER_ = 'Andrea.C' AND SECURITYUSERROLE.SECURITYROLE = '886356'



       /* delete_from condition

        exists join securityUserRole

        where condition.SecurityUserRole == securityUserRole.RecId && securityUserRole.User == userId && securityUserRole.SecurityRole == recId;
		*/


