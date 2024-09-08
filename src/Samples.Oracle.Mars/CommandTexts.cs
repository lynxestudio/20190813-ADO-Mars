// -----------------------------------------------------------------------
// <copyright file="CommandTexts.cs" company="apifiedsignature">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Samples.Oracle.Mars
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    internal static class CommandTexts
    {
        internal const string CommandText1 = "SELECT employee_id, first_name,last_name,department_id from EMPLOYEES where manager_id = :prmManagerId";
        internal const string CommandText2 = "SELECT employee_id,TO_DATE(start_date,'dd/Month/yy') as STARTDATE,TO_DATE(end_date,'dd/Month/yy') AS ENDDATE,job_id,department_id from JOB_HISTORY where department_id = :prmDepartmentId";
        internal const string CommandText3 = "SELECT job_id,job_title,min_salary,max_salary FROM JOBS where job_id = :prmJobId";
    }
}
