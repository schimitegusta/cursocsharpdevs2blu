const URL_VIACEP = 'https://viacep.com.br/ws/@CEP/json/';

// Carregar a página
addEventListener('load', (e) => {
    console.log('Sistema carregado...');

    // Registra evento CEP
    $('#cep').addEventListener('blur',(e) => {
        var valorCampo = e.target.value;
        console.log(`O valor digitado foi '${valorCampo}'`)
        if(valorCampo.length >= 8){
            $('#endereco').style.display = 'block';
            var urlCep = URL_VIACEP.replace('@CEP', valorCampo);
            getJson(urlCep)
            .then((resp) =>{
                console.log(resp);
                $('#rua').value = resp.logradouro;
                $('#bairro').value = resp.bairro;
                $('#cidade').value = resp.localidade;
                $('#uf').value = resp.uf;
                e.target.value = resp.cep;
                $('#numero').focus();
            });
        }

    });
});

function getJson(url) {
    return fetch(url)
           .then((resposta) => resposta.json());
}

function $(querySelector) {
    return document.querySelector(querySelector);
}

/*console.log('Script loaded.');
var nome, idade;

nome = prompt("Informe seu nome:");
console.log(`Nome: ${nome}`);

idade = prompt("Informe sua idade:");
console.log(`Idade: ${idade}`);
alert('aaa');*/
/*
var bloco = document.getElementById('bloco');
var textoBloco = document.querySelector('#bloco span');

bloco.addEventListener('mouseover',function(e){
    bloco.style.backgroundColor = 'blue';
    textoBloco.textContent = 'AZUL';
});

bloco.addEventListener('mouseout',function(e){
    bloco.style.backgroundColor = 'red';
    textoBloco.textContent = 'VERMELHO';
});
*/