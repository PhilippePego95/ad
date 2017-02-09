package org.institutoserpis.ad;

import javax.persistence.Persistence;

import java.sql.Date;

import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;


public class Hibernate {
	public static void main (String[]args){
		EntityManagerFactory entityManagerFactory = Persistence.createEntityManagerFactory("org.institutoserpis.ad.hpedido");
	
	EntityManager entityManager = entityManagerFactory.createEntityManager();
	entityManager.getTransaction().begin();
	
	Cliente cliente= new Cliente();
	cliente.setNombre("Cliente411");
	entityManager.persist(cliente);

	Pedido pedido=new Pedido();
	pedido.setCliente(cliente);
	java.util.Date date = new java.util.Date();
	Date fecha = new Date(date.getDate());
	pedido.setFecha(fecha);
	pedido.setImporte(100);
	entityManager.persist(pedido);

	entityManager.getTransaction().commit();
	entityManager.close();
	
	entityManagerFactory.close();
	}
	
	
}
