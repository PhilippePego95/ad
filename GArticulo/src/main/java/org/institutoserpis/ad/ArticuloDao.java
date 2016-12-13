
package org.institutoserpis.ad;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.Scanner;

import org.omg.CORBA.PUBLIC_MEMBER;

public class ArticuloDao {

	public static void main(String[] args) throws SQLException {
		Scanner tcl = new Scanner(System.in);
		Connection connection = DriverManager.getConnection("jdbc:mysql://localhost/dbprueba", "root", "sistemas");

		PreparedStatement preparedStatement = connection.prepareStatement("select * from articulo where id > ?");

		preparedStatement.setObject(1, Long.parseLong(args[0]));
		ResultSet resultSet = preparedStatement.executeQuery();
		Boolean fi = false;

		do {
			System.out.println("****************");
			System.out.println("0.Eixir");
			System.out.println("1.Nou");
			System.out.println("2.Modificar");
			System.out.println("3.Eliminar");
			System.out.println("4.Consultar");
			System.out.println("5.Llistar");
			System.out.println("****************");
			int opc = tcl.nextInt();

			switch (opc) {
			case 0:
				fi = true;
				break;
			case 1:
				nou();
				break;
			default:
				break;
			}
		} while (fi == false);

		// Para sentencias que no sean consultas:
		// preparedStatement.executeUpdate(); //que devuelve el número de filas
		// afectadas

		// Statement statement = connection.createStatement();
		// ResultSet resultSet = statement.executeQuery("select * from
		// articulo");

		System.out.printf("%5s %-30s %10s %9s\n", "ID", "NOM", "PREU", "CATEGORIA");
		while (resultSet.next()) {
			System.out.printf("%5s %-30s %10s %9s\n", resultSet.getObject("id"), resultSet.getObject("nombre"),
					resultSet.getObject("precio"), resultSet.getObject("categoria"));
		}

		// statement.close();
		preparedStatement.close();
		connection.close();
		System.out.println("Fi");
	}
	public static void nou(){
		
	}
}