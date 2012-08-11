function formClick($key){
	$key.select();
}

function init(){
	document.getElementById("ddd_celular").value = "";
	document.getElementById("celular").value = "";
	document.getElementById("apresentacao").value = "apresentacao";
		
	
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

function saibaMais(){
	formClean();
	document.getElementById("classCelular").className = "hidden";
	document.getElementById("classDisponivel").className = "hidden";
	document.getElementById("saibaMais").className= "saibaMais";
}

function ddd_regexp(ddd){
	regDDD = /(1[1-9])$|(2[1-8])$|(3[1-8])$|(4[1-9])$|(5[1-5])$|(6[1-9])$|(7[1-9])$|(8[1-9])$|(9[1-9])$/
	ok = regDDD.exec(ddd);
	if (!ok){
		formClean();
		document.getElementById("warning_ddd").className = "warnings right";
	} 
	
	if (ddd == 11) {
		formClean();
		document.getElementById("numeroSP").className = "numeroSP";
	} else {
		formClean();
		document.getElementById("numeroSP").className = "hidden";
	}
}

function fone_regexp(fone){
	regFone = /([6-9]\d{3}\-\d{4})$/
	ok = regFone.exec(fone);
	
	if (!ok) {
		formClean();
		document.getElementById("warning_celular_2").className = "right";
	} else {
		if (document.getElementById("ddd_celular").value.length == 0){
			document.getElementById("warning_ddd").className = "right";
		} else {
			ddd = document.getElementById("ddd_celular").value;
			var op = queOperadora(ddd,fone);
			formClean();
	
			switch (op) {
				case "CLARO" : 				formClean() ; document.getElementById("claro").className = ""; break;
				case "CTBC" : 				formClean() ; document.getElementById("ctbc").className = ""; break;
				case "OI" : 				formClean() ; document.getElementById("oi").className = ""; break;
				case "SERCOMTEL" : 			formClean() ; document.getElementById("sercomtel").className = ""; break;
				case "TIM" : 				formClean() ; document.getElementById("tim").className = ""; break;
				case "VIVO" : 				formClean() ; document.getElementById("vivo").className = ""; break;
				default : 					formClean() ; document.getElementById("warning_celular").className = "right"; break;
			}
		}
	}
}
