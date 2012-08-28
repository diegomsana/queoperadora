function formClick($key){
	$key.select();
}

function init(){
	document.getElementById("ddd_celular").value = "";
	document.getElementById("celular").value = "";
		
	formClean();
}

function formClean(){
	document.getElementById("claro").className = "hidden";
	document.getElementById("ctbc").className = "hidden";
	document.getElementById("oi").className = "hidden";
	document.getElementById("sercomtel").className = "hidden";
	document.getElementById("tim").className = "hidden";
	document.getElementById("vivo").className = "hidden";
	document.getElementById("warning_ddd").className = "hidden";
	document.getElementById("warning_celular").className = "hidden";
	document.getElementById("warning_celular_2").className = "hidden";	
}


function estadoClean(){
	document.getElementById("estado").className = "hidden";
}

function digito9Clean(){
	document.getElementById("numeroSP").className = "hidden";
}

function new_ddd_regexp(meu_ddd){
	//regDDD = /(1[1-9])$|(2[1-8])$|(3[1-8])$|(4[1-9])$|(5[1-5])$|(6[1-9])$|(7[1-9])$|(8[1-9])$|(9[1-9])$/

	ddd = verifica_ddd(meu_ddd);
	if (ddd[0] != ""){
		formClean();
		document.getElementById("estado").className = "estado";

		if (meu_ddd == 11) {
			document.getElementById("numeroSP").className = "numeroSP";
		} else {
			document.getElementById("numeroSP").className = "hidden";
		}
	
		document.getElementById("bandeira").getElementsByTagName("img")[0].src = "img/bandeiras/" + ddd[1];
		document.getElementById("bandeira").getElementsByTagName("img")[0].title = ddd[0];

		document.getElementById("nomeEstado").innerHTML = ddd[0];
	} else {
		estadoClean();
		digito9Clean();
		formClean();
		document.getElementById("warning_ddd").className = "warning_ddd";
	}
}


function fone_regexp(fone){
	//regFone = /([6-9]\d{3}\-\d{4})$/
	//ok = regFone.exec(fone);

	if (document.getElementById("ddd_celular").value.length == 0){
		document.getElementById("warning_ddd").className = "warning_ddd";
	
	} else if(document.getElementById("celular").value == "____-____") {
		document.getElementById("warning_celular_2").className = "warning_celular";
		
	} else {
		ddd = document.getElementById("ddd_celular").value;
		var op = queOperadora(ddd,fone);
		
		formClean();
		new_ddd_regexp(ddd);

		switch (op) {
			case "CLARO" : 				formClean() ; document.getElementById("claro").className = ""; break;
			case "CTBC" : 				formClean() ; document.getElementById("ctbc").className = ""; break;
			case "OI" : 				formClean() ; document.getElementById("oi").className = ""; break;
			case "SERCOMTEL" : 			formClean() ; document.getElementById("sercomtel").className = ""; break;
			case "TIM" : 				formClean() ; document.getElementById("tim").className = ""; break;
			case "VIVO" : 				formClean() ; document.getElementById("vivo").className = ""; break;
			default : 					formClean() ; document.getElementById("warning_celular").className = "warning_celular"; break;
		}
	}
}
