# EntityFrameworkProj
The implementation of a program working with a Postgresql DBMS on a local computer

Each Doctor has one specialization, and different doctors may have the same specialization. In addition, each doctor can have an arbitrary number of personal certificates.

In addition to the functionality for creating, editing and deleting any records of all three entities, the program performs the following queries at the user's request and provides results:

How many doctors have a specialization with a given identifier?

What is the name of the specialization (Name) for which the certificate with the specified identifier was issued?

When was the last chronologically issued certificate for a doctor with the specified ID?

