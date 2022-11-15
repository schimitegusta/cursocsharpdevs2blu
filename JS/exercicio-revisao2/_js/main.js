var listCharacter = new Array();
const charactersList = document.getElementById('charactersList');

addEventListener('load', function(){
    getAPI(URL_API_CHARACTER, criaListaCharacter);
});


const criaListaCharacter = (data) => {
    let main = getElement('main');
    console.log(data);
    listCharacter = new Array();

    data.forEach(character => {
        let html = document.createElement('div');
        html.classList.add('card', 'col-2', 'my-4', 'ms-1', 'hvr-grow');
        html.addEventListener('click', ()=> mostraDetalhesCharacter(character))

        let htmlBody = `
        <li>
            <div class="card-header">
                <img class="card-img-top card-img" src="${character.img}" alt="${character.name}">
            </div>
            <div class="card-body bg-white">
                <h2 class="text-secondary text-center">${character.name}</h2>
            </div>
        </li>`;

        html.innerHTML = htmlBody;
        main.appendChild(html);
        listCharacter.push(character);
    });
    charactersList.innerHTML = character;
}

const mostraDetalhesCharacter = (character) => {
    console.log(character);
    let div = document.createElement('div');
    getElement('#modal-body').innerHTML = "";
    div.classList.add('card', 'card-modal', 'col-12', 'my-4');

    let cardBody = `
            <div class="card-header card-header-modal">
                <img class="card-img-top" src="${character.img}" alt="Foto Personagem">
            </div>
            <div class="card-body bg-white">
                <h1 class="text-secondary text-center">${character.name}</h1>
                <article>
                    <ul class="list-group">
                        <li class="list-group-item">Apelido: ${character.nickname}</li>
                        <li class="list-group-item">Status: ${character.status}</li>
                        <li class="list-group-item">Data de Nascimento: ${character.birthday}</li>
                        <li class="list-group-item">Profissão: ${character.occupation}</li>
                        <li class="list-group-item">Ator: ${character.portrayed}</li>
                    </ul>
                </article>
            </div>
        `;
        div.innerHTML = cardBody;
        getElement('#modal-body').appendChild(div);

        $('#charModal').modal('show');
}