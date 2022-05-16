using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using AutomatizadorDeTestes.Dominio.ModuloDisciplina;
using AutomatizadorDeTestes.Dominio.ModuloMateria;
using AutomatizadorDeTestes.Dominio.ModuloQuestao;
using AutomatizadorDeTestes.Dominio.ModuloTeste;
using AutomatizadorDeTestes.WinAppForm.Compartilhado;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace AutomatizadorDeTestes.WinAppForm.ModuloTeste
{
    public class ControladorTeste : ControladorBase
    {
        private readonly IRepositorioTeste repositorioTeste;
        private readonly IRepositorioQuestao repositorioQuestao;
        private readonly IRepositorioMateria repositorioMateria;
        private readonly IRepositorioDisciplina repositorioDisciplina;

        private TabelaControlTeste tabelaTestes;
        public ControladorTeste(IRepositorioTeste repositorioTeste, IRepositorioQuestao repositorioQuestao, IRepositorioMateria repositorioMateria, IRepositorioDisciplina repositorioDisciplina)
        {
            this.repositorioTeste = repositorioTeste;
            this.repositorioQuestao = repositorioQuestao;
            this.repositorioMateria = repositorioMateria;
            this.repositorioDisciplina = repositorioDisciplina;
        }

        public void Duplicar()
        {
            Teste testeSelecionado = ObtemTesteSelecionado();

            if (testeSelecionado == null)
            {
                MessageBox.Show("Selecione um teste primeiro",
                "Duplicação de Testes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Teste testeDuplicado = new Teste();
            CopiaTeste(testeSelecionado, testeDuplicado);

            var disciplinas = repositorioDisciplina.SelecionarTodos();
            var materias = repositorioMateria.SelecionarTodos();
            var questoes = repositorioQuestao.SelecionarTodos();

            TelaCadastroTeste tela = new TelaCadastroTeste(repositorioQuestao, questoes, disciplinas, materias);
            tela.Teste = testeDuplicado;

            tela.GravarRegistro = repositorioTeste.Inserir;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarTestes();
            }

        }

        private static void CopiaTeste(Teste testeSelecionado, Teste testeDuplicado)
        {
            testeDuplicado.Titulo = testeSelecionado.Titulo;
            testeDuplicado.Disciplina = testeSelecionado.Disciplina;
            testeDuplicado.Materia = testeSelecionado.Materia;
            testeDuplicado.Data = testeSelecionado.Data;
            testeDuplicado.NumeroQuestoes = testeSelecionado.NumeroQuestoes;
        }

        public void GerarPdf()
        {
            Teste testeSelecionado = ObtemTesteSelecionado();

            string nomeArquivo = @"C:\Users\%USERPROFILE%\Documents\Teste.pdf";

            FileStream arquivoPdf = new FileStream(nomeArquivo, FileMode.Create);
            Document doc = new Document(PageSize.A4);
            PdfWriter escritorPdf = PdfWriter.GetInstance(doc, arquivoPdf);

            doc.Open();
            string dados = "";

            Paragraph paragrafoTitulo = new Paragraph(dados);

            paragrafoTitulo.Alignment = Element.ALIGN_CENTER;
            paragrafoTitulo.Add(testeSelecionado.Titulo + "\n");
            paragrafoTitulo.Add("Disciplina: " + testeSelecionado.Disciplina + "\n");
            paragrafoTitulo.Add("Matéria: " + testeSelecionado.Materia + "\n");
            paragrafoTitulo.Add("Data: " + testeSelecionado.Data.Date + "\n\n\n");

            Paragraph paragrafoQuestoes = new Paragraph(dados);
            paragrafoQuestoes.Alignment = Element.ALIGN_LEFT;

            var questoes = testeSelecionado.Questoes;

            foreach (var questao in questoes)
            {
                CriarCelula(questao.Descricao);
                paragrafoQuestoes.Add(questao.Descricao.ToString() + "\n");
            }

            doc.Open();
            doc.Add(paragrafoTitulo);
            doc.Add(paragrafoQuestoes);
            doc.Close();

            MessageBox.Show("PDF criado com sucesso.",
            "Geração de PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private static PdfPCell CriarCelula(string texto)
        {
            var celula = new PdfPCell(new Phrase("Código"));

            return celula;
        }

        public override void Inserir()
        {
            var disciplinas = repositorioDisciplina.SelecionarTodos();
            var materias = repositorioMateria.SelecionarTodos();
            var questoes = repositorioQuestao.SelecionarTodos();

            TelaCadastroTeste tela = new TelaCadastroTeste(repositorioQuestao, questoes, disciplinas, materias);
            tela.Teste = new Teste();

            tela.GravarRegistro = repositorioTeste.Inserir;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarTestes();
            }
        }
        public override void Excluir()
        {
            Teste testeSelecionado = ObtemTesteSelecionado();

            if (testeSelecionado == null)
            {
                MessageBox.Show("Selecione um teste primeiro",
                "Exclusão de Testes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir o teste?",
                "Exclusão de Testes", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioTeste.Excluir(testeSelecionado);
                CarregarTestes();
            }
        }

        public override UserControl ObtemListagem()
        {
            if (tabelaTestes == null)
                tabelaTestes = new TabelaControlTeste();

            CarregarTestes();

            return tabelaTestes;
        }

        public override ConfiguracaoToolBoxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolBoxTeste();
        }


        private Teste ObtemTesteSelecionado()
        {
            var id = tabelaTestes.ObtemNumeroTesteSelecionado();

            return repositorioTeste.SelecionarPorId(id);
        }

        private void CarregarTestes()
        {
            List<Teste> testes = repositorioTeste.SelecionarTodos();

            tabelaTestes.AtualizarRegistros(testes);

            TelaPrincipal.Instancia.AtualizarRodape($"Visualizando {testes.Count} testes.");
        }

    }
}
