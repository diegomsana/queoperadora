#-*- encoding: utf-8 -*-
__author__ = "Eduardo Orige"
__credits__ = ["Eduardo Orige"]
__maintainer__ = "Eduardo Orige"
__email__ = "eduardo.orige@gmail.com"

# Verifica qual estado pertence o ddd e retorna com o nome por extenso e nome do arquivo que deve ser colocada a bandeira
# podem ser colocados outros dados, mas isto n�o � o foco. 
#
# Este arquivo foi feito a partir do ddd.js, segundo as suas regras.


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
}



def verifica_ddd(meu_ddd):
	if 11 <= meu_ddd <= 19:
	    return ESTADOS["SP"]

	# RIO DE JANEIRO
	elif meu_ddd == 21 or meu_ddd == 22 or meu_ddd == 24 :
	    return ESTADOS["RJ"]

	# ESPIRITO SANTO
	elif meu_ddd == 27 or meu_ddd == 28:
	    return ESTADOS["ES"]

	# MINAS GERAIS
	elif 31 <= meu_ddd <= 35 :
	    return ESTADOS["MG"]
	elif meu_ddd == 37 or meu_ddd == 38:
	    return ESTADOS["MG"]

	# PARANA
	elif 41 <= meu_ddd <= 46:
	    return ESTADOS["PR"]

	# SANTA CATARINA
	elif 47 <= meu_ddd <= 49:
	    return ESTADOS["SC"]

	# RIO GRANDE DO SUL
	elif meu_ddd == 51 or meu_ddd >= 53 and meu_ddd <= 55:
	    return ESTADOS["RS"]

	# DISTRITO FEDERAL 
	elif meu_ddd == 61:
	    return ESTADOS["DF"]

	# GOIAS
	elif meu_ddd == 62 or meu_ddd == 64:
	    return ESTADOS["GO"]

	# TOCANTINS
	elif meu_ddd == 63:
	    return ESTADOS["TO"]

	# MATO GROSSO 
	elif meu_ddd == 65 or meu_ddd == 66:
	    return ESTADOS["MT"]

	# MATO GROSSO DO SUL
	elif meu_ddd == 67:
	    return ESTADOS["MS"]

	# ACRE
	elif meu_ddd == 68:
	    return ESTADOS["AC"]

	# RONDONIA
	elif meu_ddd == 69:
	    return ESTADOS["RO"]

	# BAHIA
	elif meu_ddd == 71 or meu_ddd == 73 or meu_ddd == 74 or meu_ddd == 75 or meu_ddd == 77:
	    return ESTADOS["BA"]

	# SERGIPE
	elif meu_ddd == 79:
	    return ESTADOS["SE"]

	# PERNAMBUCO
	elif meu_ddd == 81 or meu_ddd == 87:
	    return ESTADOS["PE"]

	# ALAGOAS
	elif meu_ddd == 82:
	    return ESTADOS["AL"]

	# PARAIBA
	elif meu_ddd == 83:
	    return ESTADOS["PB"]

	# RIO GRANDE DO NORTE
	elif meu_ddd == 84:
	    return ESTADOS["RN"]

	# CEARA
	elif meu_ddd == 85 or meu_ddd == 88:
	    return ESTADOS["CE"]

	# PIAUI
	elif meu_ddd == 86 or meu_ddd == 89:
	    return ESTADOS["PI"]

	# PARA	
	elif meu_ddd == 91 or meu_ddd == 93 or meu_ddd == 94:
	    return ESTADOS["PA"]

	# AMAZONAS
	elif meu_ddd == 92 or meu_ddd == 97:
	    return ESTADOS["AM"]

	# RORAIMA
	elif meu_ddd == 95:
	    return ESTADOS["RR"]

	# AMAPA
	elif meu_ddd == 96:
	    return ESTADOS["AP"]

	# MARANHAO
	elif meu_ddd == 98 or meu_ddd == 99:
	    return ESTADOS["MA"]

	# DDD INVALIDO
	else :
	    return [False,False]
	
