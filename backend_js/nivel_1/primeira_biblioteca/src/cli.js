import fs from "fs";
import path from "path";
import trataErros from "./errors/funcoesErros.js";
import { contaPalavras } from "./index.js";
import { montaSaidaArquivo } from "./helpers.js";
import { Command } from "commander";

const program = new Command();

program
  .version("0.0.1")
  .option("-t, --texto <string>", "caminho do texto a ser processado")
  .option(
    "-d, --destino <string>",
    "caminho da pasta onde salvar os resultados"
  )
  .action((options) => {
    const { texto, destino } = options;
    if (!texto || !destino) {
      console.error("erro: favor inserir o caminho de origem e destino");
      program.help();
      return;
    }
    const caminhoTexto = path.resolve(texto);
    const caminhoDestino = path.resolve(destino);
    try {
      processaArquivo(caminhoTexto, caminhoDestino);
      console.log("Texto processado com sucesso!");
    } catch (erro) {
      console.log("Ocorreu um erro no processamento", erro);
    }
  });

program.parse();

function processaArquivo(texto, destino) {
  fs.readFile(texto, "utf-8", (erro, texto) => {
    try {
      if (erro) throw erro;
      const resultado = contaPalavras(texto);
      criaESalvaArquivos(resultado, destino);
    } catch (erro) {
      console.log(erro);
      console.log(trataErros(erro));
    }
  });
}

// Código utilizando o async await
// async function criaESalvaArquivos(listaPalavras, endereco) {
//   const arquivoNovo = `${endereco}/resultato.txt`;
//   const textoPalavras = JSON.stringify(listaPalavras);
//   try {
//     await fs.promises.writeFile(arquivoNovo, textoPalavras);
//     console.log("Arquivo criado");
//   } catch (erro) {
//     throw erro;
//   }
// }

function criaESalvaArquivos(listaPalavras, endereco) {
  const arquivoNovo = `${endereco}/resultado.txt`;
  const textoPalavras = JSON.stringify(montaSaidaArquivo(listaPalavras));

  fs.promises
    .writeFile(arquivoNovo, textoPalavras)
    .then(() => {
      console.log("Arquivo criado!");
    })
    .catch((erro) => {
      throw erro;
    })
    .finally(() => {
      console.log("Operação finalizada");
    });
}
