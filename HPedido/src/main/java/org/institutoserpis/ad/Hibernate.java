package org.institutoserpis.ad;

import java.math.BigDecimal;
import java.sql.Date;
import java.util.Calendar;
import java.util.List;
import java.util.Scanner;

import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;

import org.hibernate.boot.model.source.spi.IdentifierSourceSimple;
import org.hibernate.persister.walking.spi.MetamodelGraphWalker;

public class Hibernate {
	private static EntityManagerFactory entityManagerFactory = Persistence.createEntityManagerFactory("org.institutoserpis.ad.hpedido");
	public static void main(String[] args) {
		
		Scanner scanner = new Scanner(System.in);
		int opcion = 0;
		do{
			System.out.println("------------------ MENÚ -------------------");
			System.out.println("O. Eixir");
			System.out.println("1. Nou ..."); //Añadimos en todas
			System.out.println("2. Modificar ..."); //entityManager.flush
			System.out.println("3. Eliminar ..."); //entityManager.remove
			System.out.println("4. Consultar ...");
			System.out.println("5. Llistar ...");
			System.out.print("Una altra opció: ");
			opcion = scanner.nextInt();
			System.out.println("-------------------------------------------");
			
			switch(opcion){
				case 0: 
					System.out.println("Adeu");
					SQLHelper.close_EntityManagerFactory(entityManagerFactory);
					break;
					
				case 1:
					int opcion1 = 0;
					do {
						System.out.println("------------------ FICAR -------------------");
						System.out.println("O. Enrere");
						System.out.println("1. Categoria");
						System.out.println("2. Articulo");
						System.out.println("3. Client");
						System.out.println("4. Pedido");
						System.out.println("5. Pedido linia");
						System.out.print("Tria una opción, per favor: ");
						opcion1 = scanner.nextInt();
						System.out.println("---------------------------------------------");
						
						switch (opcion1) {
						case 0:
							break;

						case 1:
							System.out.print("Escriu un nom: ");
							String nombre = scanner.next();
							SQLHelper.insert_categoria(entityManagerFactory, nombre);
							
						case 2:
							System.out.print("Escriu un articul: ");
							String nombrearticulo = scanner.next();
							System.out.print("Escru un preu: " );
							String precioart = scanner.next();
							System.out.print("Donam un ID d'una Categoria: ");
							String idcategoria = scanner.next();
							SQLHelper.insert_articulo(entityManagerFactory, nombrearticulo, precioart, idcategoria);
							
						case 3:
							System.out.print("Nom del client: ");
							String nombrecliente = scanner.next();
							SQLHelper.insert_cliente(entityManagerFactory, nombrecliente);
							
						case 4:
							System.out.print("ID del client: ");
							String idcliente = scanner.next();
							System.out.print("Preu: ");
							String precio = scanner.next();
							SQLHelper.insert_pedido(entityManagerFactory, idcliente, precio);
							
						case 5:
							System.out.print("ID del pedido: ");
							String pedidoid = scanner.next();
							System.out.print("ID del articulo: ");
							String articuloid = scanner.next();
							System.out.print("Unitats: ");
							String unid = scanner.next();
							SQLHelper.insert_pedidoLinea(entityManagerFactory, pedidoid, articuloid, unid);
						}
					} while (opcion1 != 0);
					break;
					
				case 2:
					int opcion2= 0;
					do {
						System.out.println("------------------ MODIFICAR -------------------");
						System.out.println("O. Enrere");
						System.out.println("1. Categoria");
						System.out.println("2. Articulo");
						System.out.println("3. Client");
						System.out.println("4. Pedido");
						System.out.println("5. Pedido linia");
						System.out.print("Tria una opció, per favor: ");
						opcion2 = scanner.nextInt();
						System.out.println("----------------------------------------------");
						
						switch (opcion2) {
						case 0:
							break;

						case 1:
							System.out.print("ID de la categoria a cambiar: ");
							String nidcateogria = scanner.next();
							System.out.print("Nou nom de la categoria: ");
							String nncategoria = scanner.next();
							SQLHelper.update_categoria(entityManagerFactory, nidcateogria, nncategoria);
						}
					} while (opcion2 != 0);
					break;
				case 3:
					
				case 4:
					int opcion4 = 0;
					do {
						System.out.println("------------------ CONSULTAR -------------------");
						System.out.println("O. Enrere");
						System.out.println("1. Categoria");
						System.out.println("2. Articulo");
						System.out.println("3. Client");
						System.out.println("4. Pedido");
						System.out.println("5. Pedido linia");
						System.out.print("Tria una opció, per favor: ");
						opcion4 = scanner.nextInt();
						System.out.println("----------------------------------------------");
						
						switch (opcion4) {
						case 0:
							break;

						case 1:
							System.out.print("Inserta ID de la categoria: ");
							String id = scanner.next();
							SQLHelper.select_categoria(entityManagerFactory, id);
						}
					} while (opcion4 != 0);
					break;
					
				case 5:
					int opcion5 = 0;
					do {
						System.out.println("------------------ LISTAR -------------------");
						System.out.println("O. Enrere");
						System.out.println("1. Categoria");
						System.out.println("2. Articulo");
						System.out.println("3. Client");
						System.out.println("4. Pedido");
						System.out.println("5. Pedido linia");
						System.out.print("Tria una opció, per favor: ");
						opcion5 = scanner.nextInt();
						System.out.println("----------------------------------------------");
						
						switch (opcion5) {
						case 0:
							break;

						case 1:
							SQLHelper.select_categorias(entityManagerFactory);
						}
					} while (opcion5 != 0);
					break;
			}
		} while(opcion!=0);
	}	
}
