# How to use Multiple Active Result Sets with ADO.NET

Multiple Active Result Sets (MARS) is a feature supported by ADO.NET that allows the execution of multiple batches on a single connection. In previous versions, only one batch could be executed at a time against a single connection. When using a MARS-enabled connection, multiple logical batches can be executed on a single connection. Executing multiple batches with MARS does not imply simultaneous execution of operations.

To access multiple result sets using SqlDataReader objects, multiple SqlCommand objects will need to be used. When MARS is enabled, each command object used adds an additional session to the connection.

The following program demonstrates how to use a Sql Server Connection with MARS enabled.

Fig 1. MARS-enabled connection string


Fig 2. Data access class with two commands.


Fig 3. Main program.


Fig 4. Running the example.


Download example source code.
