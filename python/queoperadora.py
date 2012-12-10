#-*- coding: utf-8 -*-
__author__ = "Eduardo Orige"
__credits__ = ["Eduardo Orige"]
__version__ = "0.02"
__maintainer__ = "Eduardo Orige"
__email__ = "eduardo.orige@gmail.com"
__status__ = "Em Producao"

import sys

class QueOperadora:
	"""
	Classe com todos os métodos utilizados para verificar um número de celular e sua operadora.
	"""
	def __init__(self):
		pass
		
	def operadoras(self):
		"""
		Mostra as operadoras que estão disponiveis para analise no sistema.
		"""
		operadoras_disponiveis = ['Claro','CTBC','Oi','Sercomtel','TIM','Vivo',]
									
		return sorted(operadoras_disponiveis)

	def regexCelular(self,celular):
		"""
		Função que verifica se o celular passado corresponde ao padrão solicitado
		e se o número tambem é valido.
		Ex: 99 9999-9999
		"""
		import re
		test = re.compile('([1-9][1-9]\s[6-9]\d{3}\-\d{4}$)')
		if test.match(celular):
			return True
		else:
			return False

	def queOperadora(self,celular):
		"""		
		Verifica corretamente seguindo o padrao anterior de numero de celular: 99 9999-9999
		Se padrão nao for seguido, função retorna False.
		
		Primeiro verifica-se as exceções dos prefixos com 4 digitos depois então verifica-se 
		os numeros "padroes".
		"""		
		ddd = int(celular[:2])
		cel = int(celular[3:5])
		pre_cel = int(celular[3:7])
		#---- SP -----#
		if 11 <= ddd <= 19:
			if 6340 <= pre_cel <= 6369:
				return "TIM"
			
			elif (	6300 <= pre_cel <= 6339 or
					6168 <= pre_cel <= 6181 or
					6589 <= pre_cel <= 6599 or
					7052 <= pre_cel <= 7062 or
					cel == 76 			or
					8800 <= pre_cel <= 8899 ):
					
				return "CLARO"
			
			elif ( 	6057 <= pre_cel <= 6060 or
					6182 <= pre_cel <= 6199 or
					6370 <= pre_cel <= 6499 or
					pre_cel == 7099 or
					71 <= cel <= 75 or
					cel == 95 or
					cel == 99 ):
				return "VIVO"
				#TODO
				#
				#TESTADO E NÃO ENCONTRADOS NUMEROS SUFICIENTES DA CTBC
				#elif cel == 99 onde a vivo nao esta: return CTBC
			
			elif (	6100 <= pre_cel <= 6167	or
					6200 <= pre_cel <= 6299 or
					cel == 65 or
					6651 <= pre_cel <= 6799 or
					cel == 68 or
					pre_cel == 6999 or
					7971 <= pre_cel <= 7999 or
					8010 <= pre_cel <= 8099):
				return "OI"
				
			else:	
				if 81 <= cel <= 87:
					return "TIM"

				elif 91 <= cel <= 94:
					return "CLARO"

				elif 96 <= cel <= 99:
					return "VIVO"

				else:
					return None

		#---- RJ, ES ----#
		elif ddd == 21 or ddd == 22 or ddd == 24 or ddd == 27 or ddd == 28:
			if cel == 71 or cel == 72 or cel == 95:
				return "VIVO"
			
			elif 74 <= cel <= 76:
				return "CLARO"
			
			elif 80 <= cel <= 83:
				return "TIM"
			
			elif 84 <= cel <= 86 or 87 <= cel <= 89:
				return "OI"

			elif 91 <= cel <= 94:
				return "CLARO"
							
			elif 96 <= cel <= 99:
				return "VIVO"
				
			else:
				return None

		#---- MG ----#
		elif  31 <= ddd <= 35 or ddd == 37 or ddd == 38:
			if 81 <= cel <= 84:
				return "CLARO"
			
			elif 85 <= cel <= 89:
				return "OI"

			elif 91 <= cel <= 94:
				return "TIM"

			elif 95 <= cel <= 99:
				return "VIVO"
			
			#TESTADO E NAO ENCONTRADO CELULARES COM CTBC
			#elif ( 	9960 <= pre_cel <= 9979 or 
			#		9991 <= pre_cel <= 9999 ):
			#	return "CTBC"

			else:
				return None	

		#---- SC, PR ----#
		elif 41 <= ddd <= 49:
			if ddd == 43 and cel == 81:
				return "TIM"

			elif ddd == 43 and 9941 <= pre_cel <= 9998:
				return "SERCOMTEL"

			else:
				if 84 <= cel <= 85:
					return "OI"

				elif 87 <= cel <= 88:
					return "CLARO"

				elif 91 <= cel <= 94:
					return "VIVO"
					
				elif 96 <= cel <= 99:
					return "TIM"

				else:
					return None

		#---------- RS --------------#
		elif ddd == 51 or 53 <= ddd <= 55:
			if ddd == 53 and 9911 <= pre_cel <= 9920: #PELOTAS E REGIAO
				return "TIM"
			else :	
				if 81 <= cel <= 82:
					return "TIM"

				elif 84 <= cel <= 85:
					return "OI"
				
				elif 91 <= cel <= 94:
					return "CLARO"
			
				elif 95 <= cel <= 99:
					return "VIVO"
			
				else:
					return None	 

		#---- Centro Oeste ---------#
		elif 61 <= ddd <= 69:
			if 9551 <= pre_cel <= 9559:
				return "CLARO"
			
			elif cel == 86:
				return "OI"
			
			#TESTES EFETUADOS E NUMERO DE CELULARES CTBC É MUITO BAIXO
			#elif cel == 99 : onde nao existe vivo
			#return "CTBC"
			
			else:
				if 81 <= cel <= 82:
					return "TIM"

				elif 84 <= cel <= 85:
					return "OI"

				elif 91 <= cel <= 94:
					return "CLARO"

				elif 96 <= cel <= 99:
					return "VIVO"

				else:
					return None	

		#---------- BA, SE ----------#
		elif ddd == 71 or ddd == 73 or ddd == 74 or ddd == 75 or ddd == 77 or ddd == 79:
			if 81 <= cel <= 83:
				return "CLARO"

			elif 86 <= cel <= 88:
				return "OI"
			
			elif 91 <= cel <= 94:
				return "TIM"
					
			elif 96 <= cel <= 99:
				return "VIVO"

			else:
				return None
				
		#---------- Nordeste --------------#
		elif 81 <= ddd <= 89:
			if 84 <= cel <= 86:
				return "OI"
			
			elif 8719 <= pre_cel <= 8721:
				return "TIM"
				
 			else:
				if 81 <= cel <= 83:
					return "VIVO"

				elif 87 <= cel <= 88:
					return "OI"

				elif 91 <= cel <= 94:
					return "CLARO"

				elif 96 <= cel <= 99:
					return "TIM"

				else:
					return None

		#---------- Norte --------------#
		elif 91 <= ddd <= 99:
			if 80 <= cel <= 83:
				return "OI"

			elif cel == 84:
				return "CLARO"

			elif 87 <= cel <= 88:
				return "OI"

			elif 91 <= cel <= 94:
				return "VIVO"

			elif 96 <= cel <= 99:
				return "OI"

			else:
				return None
		else:
			return False

	def terminal(self):

		Error = "Utilize: \npython queoperadora.py [DDD] [CELULAR]\npython queoperadora.py 99 9999-9999"
		

		if len(sys.argv) == 3:
			
			celular = ""
			for param in sys.argv[1:]: celular += param + " "

			
			operadora = self.queOperadora(celular)

			if operadora == None: 
				print "! Operadora não encontrada !"
			else: 
				print operadora
			
			sys.exit(0)
		
		else:
			print Error
			sys.exit(1)
		
	def main(self):
		self.terminal()



if __name__ == '__main__':
	q = QueOperadora()
	q.terminal()