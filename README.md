# How to use Multiple Active Result Sets (MARS) with Oracle .NET

<p align="justify">
Multiple Active Result Sets (MARS) is a feature supported by ADO.NET that allows the execution of multiple batches on a single connection. In previous versions, only one batch could be executed at a time against a single connection. When using a MARS-enabled connection, multiple logical batches can be executed on a single connection. Executing multiple batches with MARS does not imply simultaneous execution of operations.
</p>

<p>
To access multiple result sets using DataReader objects, multiple Command objects will need to be used. When MARS is enabled, each command object used adds an additional session to the connection.

For enabling MARS on Sql Server connection, only adds the following property at the end of the connection string.
</p>
<pre>
connectionString="Data Source=(local);Initial Catalog=Adventureworks;Integrated Security=True;MultipleActiveResultSets=True;Persist Security Info=False"
</pre>
The following program demonstrates how to use a Oracle Connection with MARS enabled.
It runs three command to the samples database HR. The sample database can be downloaded here.

Fig 1. Running the example.
<div><img src="images/fig1.png" width="663" height="361" alt=""></div><br/>

Fig 2. Use the first Oracle Datareader for fetching data.
<div><img src="images/fig2.png" width="668" height="335" alt=""></div><br/>

Fig 3. 
<div><img src="images/fig3.png" width="668" height="361" alt=""></div><br/>

Fig 4. 
<div><img src="images/fig4.png" width="668" height="363" alt=""></div><br/>

Fig 5.
<div><img src="images/fig5.png" width="668" height="358" alt=""></div><br/>
