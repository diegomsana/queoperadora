/*
	queOperadora
	Copyright (c) 2012 Eduardo Orige (www.eduardoorige.com.br)
	Licensed under the BSD license 
	Version: 0.1
*/

function queOperadora(ddd,fone){
	cel = (fone.charAt(0) + fone.charAt(1));
	pre_cel = (fone.charAt(0) + fone.charAt(1) + fone.charAt(2) + fone.charAt(3));

	//SAO PAULO
	if (ddd >= 11 && ddd <= 19)	{
		if (pre_cel >= 6340 && pre_cel <= 6369)	{
			return "TIM";
	
		}else if ((pre_cel >= 6168 && pre_cel <= 6181) || 
			(pre_cel >= 6310 && pre_cel <= 6339) || 
			(pre_cel >= 6589 && pre_cel <= 6599) ||
			(pre_cel >= 7052 && pre_cel <= 7062) ||	
			cel == 76 ||
			(pre_cel >= 8800 && pre_cel <= 8899) ||	
			cel == 89)	{

			return "CLARO";
					
		} else if ((pre_cel >= 6057 && pre_cel <= 6060) || 
			(pre_cel >= 6182 && pre_cel <= 6199) ||
			(pre_cel >= 6370 && pre_cel <= 6499) ||
		 	pre_cel == 7099 ||
			(cel >= 71 && cel <= 75) || 
			cel == 95) {
			
			return "VIVO";
					
		} else if ((pre_cel >= 6100 && pre_cel <= 6167) || 
			(pre_cel >= 6200 && pre_cel <= 6299) || 
			cel == 65 ||
			(pre_cel >= 6651 && pre_cel <= 6799) || 
			cel == 68 || 
			pre_cel == 6999 ||
			(pre_cel >= 7971 && pre_cel <= 7999) || 
			(pre_cel >= 8010 && pre_cel <= 8099)){
			
			return "OI";

		} else if (cel >= 96 && cel <= 99) {
			return "VIVO";
		
		} else if (cel >= 91 && cel <= 94){
			return "CLARO";
		} else if (cel >= 81 && cel <= 87){
			return "TIM";
		}
	
	//RIO DE JANEIRO , ESPIRITO SANTO
	} else if (ddd >= 21 && ddd <= 28){ //RJ, ES
		if (cel >= 74 && cel <= 76){
			return "CLARO";
		
		} else if (cel == 71 || cel == 72 || cel == 95){
			return "VIVO";
	
		} else if ((cel >= 84 && cel <= 86) || (cel >= 86 && cel <= 89)){
			return "OI";
		
		} else if (cel >= 96 && cel <= 99){
			return "VIVO";

		} else if (cel >= 91 && cel <= 94){
			return "CLARO";

		} else 	if (cel >= 80 && cel <= 83) {
			return "TIM";
		}
		
	//MINAS GERAIS	
	} else if (ddd >= 31 && ddd <= 38) { 
		if (cel >= 85 && cel <= 89){
			return "OI";
		
		} else if (cel >= 95 && cel <= 99) {					
			/*TESTADO E NAO ENCONTRADO CELULARES COM CTBC
			if ((pre_cel >= 9960 && pre_cel <= 9979) || (pre_cel >= 9991 && pre_cel <= 9999)){
				return "CTBC";
			} else {
			*/			
			return "VIVO";

		} else if (cel >= 91 && cel <= 94){
			return "TIM";

		} else if (cel >= 81 && cel <= 84){
			return "CLARO";
		}
	
	//SANTA CATARINA, PARANA
	}else if (ddd >= 41 && ddd <= 49) { 
		if (ddd == 43 && pre_cel >= 9941 && pre_cel <= 9998) {
			//Parte de Maringa e regiao
			return "SERCOMTEL";
		
		} else if (cel >= 96 && cel <= 99 ){
			return "TIM";
		
		} else if (cel >= 91 && cel <= 94) {
			return "VIVO";
		
		} else if (cel == 87 || cel == 88) {
			return "CLARO";
			
		} else if (cel == 84 || cel == 85) {
			return "OI";
		}
	
	//RIO GRANDE DO SUL
	} else if (ddd >= 51 && ddd <= 55){ 
		if (ddd == 53 && pre_cel >= 9911 && pre_cel <= 9920) {
			// PELOTAS
			return "TIM"
		
		} else if (cel == 81 || cel == 82) {
			return "TIM";
		
		} else if (cel == 84 || cel == 85){
			return "OI";
		
		} else if (cel >= 91 && cel <= 84){
			return "CLARO";
		
		} else if (cel >= 95 && cel <= 99) {
			return "VIVO";
		}
	
	//CENTRO-OESTE	
	} else if (ddd >= 61 && ddd <= 69) {
		if (pre_cel >= 9551 && pre_cel <= 9959){
			return "CLARO";
					
		} else if (cel >= 96 && cel <= 99){
			/*TODO
			TESTES EFETUADOS E NUMERO DE CELULARES CTBC É MUITO BAIXO
			if cel == 99 e nao existe vivo {return "CTBC";}
			*/
			return "VIVO";

		} else if (cel >= 91 && cel <= 94) {
			return "CLARO";
		
		} else if (cel == 81 || cel == 82){
			return "TIM";
		
		} else if (cel == 84 || cel == 85){
			return "OI";
		
		} else if (cel == 86){
			return "OI";
		}
		
	//BAHIA E SERGIPE
	} else if (ddd >= 71 && ddd <= 79) {
		if (cel >= 81 && cel <= 83){
			return "CLARO";
		
		} else if (cel >= 86 && cel <= 88){
			return "OI";
		
		} else if (cel >= 91 && cel <= 94) {
			return "TIM";

		} else if (cel >= 96 && cel <= 99) {
			return "VIVO";
		}
		
	//NORDESTE
	} else if (ddd >= 81 && ddd <= 89){
		if ((pre_cel >= 8719 && pre_cel <= 8721) || (cel == 88)){
			return "TIM";

		} else if ((pre_cel >= 8100 && pre_cel <= 8200) || (cel >= 81 && cel <= 83)){
			return "VIVO";

		} else if (cel >= 84 && cel <= 86) {
			return "OI";

		} else if (cel >= 96 && cel <= 99) {
			return "TIM";
			
		} else if (cel >= 91 && cel <= 94) {
			return "CLARO";
		}
		
	//NORTE
	} else if (ddd >= 91 && ddd <= 99) {
		if (cel >= 80 && cel <= 83) {
			return "OI";
		
		} else if (cel == 84){
			return "CLARO";
		
		} else if (cel == 87 || cel == 88) {
			return "OI";
		
		} else if (cel >= 91 && cel <= 94) {
			return "VIVO";
		
		} else if (cel >= 96 && cel <= 99) {
			return "OI";		
		}


	//NAO COMPATIVEL ou DDD INVALIDO
	} else {
		return "";
	}
}