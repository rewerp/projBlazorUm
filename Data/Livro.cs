using System;

namespace projBlazorUm.Data
{
	public class Livro
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public int AnoPublicacao { get; set; }
		[ForeignKey("Autor")]
		public int AutorId { get; set; }
	}
}
