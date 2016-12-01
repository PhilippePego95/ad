package org.institutoserpis.ad;

import java.sql.*;


public class ArticuloDao {

	public static void main(String[] args) throws SQLException {
	//public static void main(String[] args) {
		Connection connection = DriverManager.getConnection("jdbc:mysql://localhost/dbprueba","root","sistemas");
		
		Statement statement = connection.createStatement();
		ResultSet resultSet = statement.executeQuery("SELECT * FROM articulo");
		
		System.out.printf("%5s %30s %10s %5s\n", "id","nombre","precio","categoria");
		while (resultSet.next()) {
			System.out.printf("%5d %30s %10s %5s\n",
					resultSet.getObject("id"),
					resultSet.getObject("nombre"),
					resultSet.getObject("precio"),
					resultSet.getObject("categoria"));

		}
		
		statement.close();		
		connection.close();
		System.out.println("fin de conexión");
	}

}
