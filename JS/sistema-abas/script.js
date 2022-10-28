addEventListener("load", (e) => {
  console.log("Sistema carregado...");

  document.querySelector("#btn-aba1").addEventListener("click", (e) => {
    $("#aba1").style.display = "block";
    $("#aba2").style.display = "none";
    $("#aba3").style.display = "none";
    $("#aba4").style.display = "none";
  });
  document.querySelector("#btn-aba2").addEventListener("click", (e) => {
    $("#aba2").style.display = "block";
    $("#aba1").style.display = "none";
    $("#aba3").style.display = "none";
    $("#aba4").style.display = "none";
  });
  document.querySelector("#btn-aba3").addEventListener("click", (e) => {
    $("#aba3").style.display = "block";
    $("#aba1").style.display = "none";
    $("#aba2").style.display = "none";
    $("#aba4").style.display = "none";
  });
  document.querySelector("#btn-aba4").addEventListener("click", (e) => {
    $("#aba4").style.display = "block";
    $("#aba1").style.display = "none";
    $("#aba2").style.display = "none";
    $("#aba3").style.display = "none";
  });
  document.querySelector("#btn-aba5").addEventListener("click", (e) => {
    $("#aba1").style.display = "none";
    $("#aba2").style.display = "none";
    $("#aba3").style.display = "none";
    $("#aba4").style.display = "none";
  });
});

function $(querySelector) {
    return document.querySelector(querySelector);
}