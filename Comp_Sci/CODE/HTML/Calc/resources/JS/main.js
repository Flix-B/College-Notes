const ansBoxLimit = 20;

/*

function setupEvents() {
  document.getElementById("1").addEventListener("click", alert("test3"));
  document
    .getElementById("2")
    .addEventListener("click", writeBtnValue("2", "Number"));
  document
    .getElementById("3")
    .addEventListener("click", writeBtnValue("3", "Number"));
  document
    .getElementById("4")
    .addEventListener("click", writeBtnValue("4", "Number"));
  document
    .getElementById("5")
    .addEventListener("click", writeBtnValue("5", "Number"));
  document
    .getElementById("6")
    .addEventListener("click", writeBtnValue("6", "Number"));
  document
    .getElementById("7")
    .addEventListener("click", writeBtnValue("7", "Number"));
  document
    .getElementById("8")
    .addEventListener("click", writeBtnValue("8", "Number"));
  document
    .getElementById("9")
    .addEventListener("click", writeBtnValue("9", "Number"));
  document
    .getElementById("0")
    .addEventListener("click", writeBtnValue("0", "Number"));
  document
    .getElementById(".")
    .addEventListener("click", writeBtnValue(".", "Number"));
  document
    .getElementById("divide")
    .addEventListener("click", writeBtnValue("1", "Operator"));
  document
    .getElementById("times")
    .addEventListener("click", writeBtnValue("1", "Operator"));
  document
    .getElementById("plus")
    .addEventListener("click", writeBtnValue("1", "Operator"));
  document
    .getElementById("minus")
    .addEventListener("click", writeBtnValue("1", "Operator"));
  document
    .getElementById("equals")
    .addEventListener("click", writeBtnValue("=", "Equals"));
}

*/

function writeBtnValue(btnValue, btnType) {
  var ansBoxObj = document.getElementById("ansBox");
  var ansBoxValue = ansBoxObj.value;
  if (ansBoxValue.length <= 0) {
    var lastChar = ansBoxValue.substr(0, 1);
  } else {
    var lastChar = ansBoxValue.substr(ansBoxValue.length - 1, 1);
  }

  // findout what thye of button
  if (btnType == "Operator") {
    //OPERATOR SECTION

    //Check if last character was an operator as well?
    if (
      lastChar == "/" ||
      lastChar == "*" ||
      lastChar == "-" ||
      lastChar == "+"
    ) {
      //The last character was an operator aswell, therefore replace last with new
      return (document.getElementById("ansBox").value =
        ansBoxValue.substr(0, ansBoxValue.length - 1) + btnValue);
    } else {
      //Last Character was a number so check limti and if ok just  add operator
      if (ansBoxObj.value.length <= ansBoxLimit - 1) {
        return (document.getElementById("ansBox").value =
          ansBoxValue + btnValue);
      } else {
        return alert("Character limit reached");
      }
    }
  }

  if (btnType == "Number") {
    //NUMBER SECTION

    if (ansBoxValue.length <= ansBoxLimit) {
      //Check limit
      return (document.getElementById("ansBox").value = ansBoxValue + btnValue);
    } else {
      return alert("Character limit reached");
    }
  }

  if (btnType == "Equals") {
    //EQUALS SECTION

    return (document.getElementById("ansBox").value = eval(ansBoxValue));
  } else {
    //ERROR - didt etect a valid nbutton type - coder made a mistake!!

    alert("button type not supplied");
  }
}
