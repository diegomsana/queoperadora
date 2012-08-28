/*
FONTE:
http://www.auxilio-a-lista.com.br/ddd-por-estado-uf.html
*/

var ESTADOS = new Object();
ESTADOS = { 
	"AC":["Acre","acre.gif"],
	"AL":["Alagoas","alagoas.gif"],
	"AM":["Amazonas","amazonas.gif"],
	"AP":["Amapá","amapa"],
	"BA":["Bahia","bahia.gif"],
	"CE":["Ceará","ceara.gif"],
	"DF":["Distrito Federal","distrito_federal.gif"],
	"ES":["Espirito Santo","espirito_santo.gif"],
	"GO":["Goiás","goias.gif"],
	"MA":["Maranhão","maranhao.gif"],
	"MG":["Minas Gerais","minas_gerais.gif"],
	"MS":["Mato Grosso do Sul","mato_grosso_do_sul.gif"],
	"MT":["Mato Grosso","mato_grosso.gif"],
	"PA":["Pará","para.gif"],
	"PB":["Paraíba","paraiba.gif"],
	"PE":["Pernambuco","pernambuco.gif"],
	"PI":["Piauí","piaui.gif"],
	"PR":["Paraná","parana.gif"],
	"RJ":["Rio de Janeiro","rio_de_janeiro.gif"],
	"RN":["Rio Grande do Norte","rio_grande_do_norte.gif"],
	"RO":["Rondonia","rondonia.gif"],
	"RR":["Roraima","roraima.gif"],
	"RS":["Rio Grande do Sul","rio_grande_do_sul.gif"],
	"SC":["Santa Catarina","santa_catarina.gif"],
	"SE":["Sergipe","sergipe.gif"],
	"SP":["São Paulo","sao_paulo.gif"],
	"TO":["Tocantins","tocantins.gif"]
};

// Verificar os ddds por estado
function verifica_ddd(meu_ddd){
	if (meu_ddd >= 11 && meu_ddd <= 19){
		return ESTADOS.SP;
	
	// RIO DE JANEIRO
	} else if (meu_ddd == 21 || meu_ddd == 22 || meu_ddd == 24) {
		return ESTADOS.RJ;
	
	// ESPIRITO SANTO
	} else if (meu_ddd == 27 || meu_ddd == 28){
		return ESTADOS.ES;

	// MINAS GERAIS
	} else if (meu_ddd >= 31 && meu_ddd <= 35) {
		return ESTADOS.MG;
	} else if (meu_ddd == 37 || meu_ddd == 38){
		return ESTADOS.MG;
	
	// PARANÁ
	} else if (meu_ddd >= 41 && meu_ddd <= 46){
		return ESTADOS.PR;
		
	// SANTA CATARINA
	} else if (meu_ddd >= 47 && meu_ddd <= 49){
		return ESTADOS.SC;
	
	// RIO GRANDE DO SUL
	} else if (meu_ddd == 51 || meu_ddd >= 53 && meu_ddd <= 55){
		return ESTADOS.RS;
	
	// DISTRITO FEDERAL 
	} else if (meu_ddd == 61){
		return ESTADOS.DF;
	
	// GOIAS
	} else if (meu_ddd == 62 || meu_ddd == 64){
		return ESTADOS.GO;
	
	// TOCANTINS
	} else if (meu_ddd == 63){
		return ESTADOS.TO;
	
	// MATO GROSSO 
	} else if (meu_ddd == 65 || meu_ddd == 66){
		return ESTADOS.MT;
	
	// MATO GROSSO DO SUL
	} else if (meu_ddd == 67){
		return ESTADOS.MS;
	
	// ACRE
	} else if (meu_ddd == 68){
		return ESTADOS.AC;
	
	// RONDONIA
	} else if (meu_ddd == 69){
		return ESTADOS.RO;
	
	// BAHIA
	} else if (meu_ddd == 71 || meu_ddd == 73 || meu_ddd == 74 || meu_ddd == 75 || meu_ddd == 77){
		return ESTADOS.BA;
	
	// SERGIPE
	} else if (meu_ddd == 79){
		return ESTADOS.SE;
	
	// PERNAMBUCO
	} else if (meu_ddd == 81 || meu_ddd == 87){
		return ESTADOS.PE;
	
	// ALAGOAS
	} else if (meu_ddd == 82){
		return ESTADOS.AL;
	
	// PARAIBA
	} else if (meu_ddd == 83){
		return ESTADOS.PB;
	
	// RIO GRANDE DO NORTE
	} else if (meu_ddd == 84){
		return ESTADOS.RN;
	
	// CEARA
	} else if (meu_ddd == 85 || meu_ddd == 88){
		return ESTADOS.CE;

	// PIAUI
	} else if (meu_ddd == 86 || meu_ddd == 89){
		return ESTADOS.PI;
		
	// PARA	
	} else if (meu_ddd == 91 || meu_ddd == 93 || meu_ddd == 94){
		return ESTADOS.PA;
	
	// AMAZONAS
	} else if (meu_ddd == 92 || meu_ddd == 97){
		return ESTADOS.AM;

	// RORAIMA
	} else if (meu_ddd == 95){
		return ESTADOS.RR;
	
	// AMAPA
	} else if (meu_ddd == 96){
		return ESTADOS.AP;
	
	// MARANHAO
	} else if (meu_ddd == 98 || meu_ddd == 99){
		return ESTADOS.MA;
	
	// DDD INVALIDO
	} else {
		return ["",""];
	}
}