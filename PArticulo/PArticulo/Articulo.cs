using System;

namespace PArticulo {

	public class Articulo {

		public Articulo (long id, string nombre, decimal? precio, long? categoria) {
			Id = id;
			Nombre = nombre;
			Precio = precio;
			Categoria = categoria;
		}

		public long Id 		   { set; get; }
		public string Nombre   { set; get; }
		public decimal? Precio { set; get; }
		public long? Categoria { set; get; }
	}
}

