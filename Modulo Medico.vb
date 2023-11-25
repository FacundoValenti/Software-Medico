Imports System.Data.SqlClient

Module Modulo_Medico
    Public conexionSql As New SqlClient.SqlConnection ' Declara una conexión a la base de datos SQL Server

    Public adaptadorsql As New SqlClient.SqlDataAdapter ' Declara un adaptador de datos SQL para conectar conjuntos de datos con la base de datos

    Public consultasql As New SqlClient.SqlCommand ' Declara un comando SQL para ejecutar consultas en la base de datos


    Public acciones As New SqlClient.SqlCommand ' Declara un comando SQL para realizar diversas acciones en la base de datos (Agregacion, Modificacion, Eliminaciones)


    Public lectordatos As SqlClient.SqlDataReader ' Declara un lector de datos SQL para leer los resultados de una consulta


    Public comandoaux4 As SqlCommand

End Module
