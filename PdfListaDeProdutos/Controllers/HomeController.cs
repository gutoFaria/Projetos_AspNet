using System.Diagnostics;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;
using PdfListaDeProdutos.Data;
using PdfListaDeProdutos.Models;

namespace PdfListaDeProdutos.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var data = _context.Produtos.ToList();
        return View(data);
    }

    [HttpPost]
    public IActionResult PDF()
    {
        var data = _context.Produtos.ToList();
        using(MemoryStream ms = new MemoryStream())
        {
            Document document = new Document(PageSize.A4,25,25,30,30);
            PdfWriter writer = PdfWriter.GetInstance(document,ms);
            document.Open();

            Paragraph p1 = new Paragraph("Lista de Produtos",new Font(Font.FontFamily.HELVETICA,20));
            p1.Alignment = Element.ALIGN_CENTER;
            p1.SpacingAfter = 10;
            document.Add(p1);

            PdfPTable table = new PdfPTable(4);

            PdfPCell c1 = new PdfPCell(new Phrase("Código",new Font(Font.FontFamily.HELVETICA,12)));
            c1.BackgroundColor = BaseColor.LIGHT_GRAY;
            c1.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            c1.BorderWidthBottom = 1f;
            c1.BorderWidthTop = 1f;
            c1.BorderWidthBottom = 1f;
            c1.BorderWidthRight = 1f;
            c1.HorizontalAlignment = Element.ALIGN_CENTER;
            c1.VerticalAlignment = Element.ALIGN_CENTER;
            table.AddCell(c1);

            PdfPCell c2 = new PdfPCell(new Phrase("Nome do Produto",new Font(Font.FontFamily.HELVETICA,12)));
            c2.BackgroundColor = BaseColor.LIGHT_GRAY;
            c2.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            c2.BorderWidthBottom = 1f;
            c2.BorderWidthTop = 1f;
            c2.BorderWidthBottom = 1f;
            c2.BorderWidthRight = 1f;
            c2.HorizontalAlignment = Element.ALIGN_CENTER;
            c2.VerticalAlignment = Element.ALIGN_CENTER;
            table.AddCell(c2);

            PdfPCell c3 = new PdfPCell(new Phrase("Quantidade",new Font(Font.FontFamily.HELVETICA,12)));
            c3.BackgroundColor = BaseColor.LIGHT_GRAY;
            c3.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            c3.BorderWidthBottom = 1f;
            c3.BorderWidthTop = 1f;
            c3.BorderWidthBottom = 1f;
            c3.BorderWidthRight = 1f;
            c3.HorizontalAlignment = Element.ALIGN_CENTER;
            c3.VerticalAlignment = Element.ALIGN_CENTER;
            table.AddCell(c3);

            PdfPCell c4 = new PdfPCell(new Phrase("Preço",new Font(Font.FontFamily.HELVETICA,12)));
            c4.BackgroundColor = BaseColor.LIGHT_GRAY;
            c4.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            c4.BorderWidthBottom = 1f;
            c4.BorderWidthTop = 1f;
            c4.BorderWidthBottom = 1f;
            c4.BorderWidthRight = 1f;
            c4.HorizontalAlignment = Element.ALIGN_CENTER;
            c4.VerticalAlignment = Element.ALIGN_CENTER;
            table.AddCell(c4);

            foreach (var item in data)
            {
                PdfPCell c_1 = new PdfPCell(new Phrase(item.Cod.ToString()));
                PdfPCell c_2 = new PdfPCell(new Phrase(item.Nome.ToString()));
                PdfPCell c_3 = new PdfPCell(new Phrase(item.Qtd.ToString()));
                PdfPCell c_4 = new PdfPCell(new Phrase(item.Preco.ToString()));

                c_1.HorizontalAlignment = Element.ALIGN_CENTER;
                c_2.HorizontalAlignment = Element.ALIGN_CENTER;
                c_3.HorizontalAlignment = Element.ALIGN_CENTER;
                c_4.HorizontalAlignment = Element.ALIGN_CENTER;

                table.AddCell(c_1);
                table.AddCell(c_2);
                table.AddCell(c_3);
                table.AddCell(c_4);
            }
            document.Add(table);
            document.Close();
            writer.Close();
            var constant = ms.ToArray();
            //var file = File(constant,"Application/vnd","ProdutoPdf.pdf");
            return File(constant,"Application/vnd","ProdutoPdf.pdf");
        }
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
