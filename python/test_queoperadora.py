#-*- encoding: utf-8 -*-
__author__ = "Eduardo Orige"
__credits__ = ["Eduardo Orige"]
__version__ = "0.01 beta"
__maintainer__ = "Eduardo Orige"
__email__ = "eduardo.orige@gmail.com"
__status__ = "Em Producao"
__description__ = 'Testes Unitarios para o QueOperadora'

import unittest
from queoperadora import QueOperadora
q = QueOperadora()


class QueOperadora_SP_Tests(unittest.TestCase):
	
	def testTIM_1(self):
		for ddd in range(11,20):
			for j in range(6340,6370):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)
				
				self.failIf(operadora != "TIM" )

	def testCLARO_1(self):
		for ddd in range(11,20):
			for j in range(6300,6340):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)

				self.failIf(operadora != "CLARO")
				
	def testCLARO_2(self):
		for ddd in range(11,20):
			for j in range(6168,6182):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)

				self.failIf(operadora != "CLARO" )		
				
	def testCLARO_3(self):
		for ddd in range(11,20):
			for j in range(6589,6600):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)

				self.failIf(operadora != "CLARO" )

	def testCLARO_4(self):
		for ddd in range(11,20):
			for j in range(7052,7063):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)

				self.failIf(operadora != "CLARO" )

	def testCLARO_5(self):
		for ddd in range(11,20):
			cel = '%s 76' % (ddd)
			operadora = q.queOperadora(cel)

			self.failIf(operadora != "CLARO" )

	def testCLARO_6(self):
		for ddd in range(11,20):
			for j in range(8800,8900):   
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)

				self.failIf(operadora != "CLARO" )

	def testVIVO_1(self):
		for ddd in range(11,20):
			for j in range(6057,6061):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)

				self.failIf(operadora != "VIVO" )
	

	def testVIVO_2(self):
		for ddd in range(11,20):
			for j in range(6182,6200):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)

				self.failIf(operadora != "VIVO" )
				
	def testVIVO_3(self):
		for ddd in range(11,20):
			for j in range(6370,6500):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)

				self.failIf(operadora != "VIVO" )

	def testVIVO_4(self):
		for ddd in range(11,20):
			cel = '%s 7099' % (ddd)
			operadora = q.queOperadora(cel)

			self.failIf(operadora != "VIVO" )
			
	def testVIVO_5(self):
		for ddd in range(11,20):
			for j in range(71,76):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)

				self.failIf(operadora != "VIVO" )
				
	def testVIVO_6(self):
		for ddd in range(11,20):
			cel = '%s 95' % (ddd)
			operadora = q.queOperadora(cel)

			self.failIf(operadora != "VIVO" )

	def testVIVO_7(self):
		for ddd in range(11,20):
			cel = '%s 99' % (ddd)
			operadora = q.queOperadora(cel)

			self.failIf(operadora != "VIVO" )
	
	def testOI_1(self):
		for ddd in range(11,20):
			for j in range(6100,6168):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)

				self.failIf(operadora != "OI" )
				
	def testOI_2(self):
		for ddd in range(11,20):
			for j in range(6200,6300):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)

				self.failIf(operadora != "OI" )

	def testOI_3(self):
		for ddd in range(11,20):
			cel = '%s 65' % (ddd)
			operadora = q.queOperadora(cel)

			self.failIf(operadora != "OI" )
			
	def testOI_4(self):
		for ddd in range(11,20):
			for j in range(6651,6800):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)

				self.failIf(operadora != "OI" )
				
	def testOI_5(self):
		for ddd in range(11,20):
			cel = '%s 68' % (ddd)
			operadora = q.queOperadora(cel)

			self.failIf(operadora != "OI" )

	def testOI_6(self):
		for ddd in range(11,20):
			cel = '%s 6999' % (ddd)
			operadora = q.queOperadora(cel)

			self.failIf(operadora != "OI" )
			
	def testOI_7(self):
		for ddd in range(11,20):
			for j in range(7971,8000):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)

				self.failIf(operadora != "OI" )

	def testOI_8(self):
		for ddd in range(11,20):
			for j in range(8010,8100):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)

				self.failIf(operadora != "OI" )				


	def testTIM_2(self):
		for ddd in range(11,20):
			for j in range(81,88):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)

				self.failIf(operadora != "TIM" )
				
	def testCLARO_8(self):
		for ddd in range(11,20):
			for j in range(91,95):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)

				self.failIf(operadora != "CLARO" )

	def testVIVO_8(self):
		for ddd in range(11,20):
			for j in range(96,100):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)

				self.failIf(operadora != "VIVO" )
				

class QueOperadora_RJ_Tests(unittest.TestCase):

	def testVIVO_1(self):
		for ddd in range(21,29):
			cel = '%s 71' % (ddd)
			operadora = q.queOperadora(cel)

			self.failIf(operadora != "VIVO" )
	
	def testVIVO_2(self):
		for ddd in range(21,29):
			cel = '%s 72' % (ddd)
			operadora = q.queOperadora(cel)

			self.failIf(operadora != "VIVO" )
			
	def testVIVO_3(self):
		for ddd in range(21,29):
			cel = '%s 95' % (ddd)
			operadora = q.queOperadora(cel)

			self.failIf(operadora != "VIVO" )
			
	def testCLARO_1(self):
		for ddd in range(21,29):
			for j in range(74,77):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)

				self.failIf(operadora != "CLARO" )
	
	def testTIM(self):
		for ddd in range(21,29):
			for j in range(80,84):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)

				self.failIf(operadora != "TIM" )

	def testOI_1(self):
		for ddd in range(21,29):
			for j in range(84,87):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)

				self.failIf(operadora != "OI" )
				
	def testOI_2(self):
		for ddd in range(21,29):
			for j in range(87,90):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)

				self.failIf(operadora != "OI" )
	
	def testCLARO_2(self):
		for ddd in range(21,29):
			for j in range(91,95):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)

				self.failIf(operadora != "CLARO" )
				
	def testVIVO_2(self):
		for ddd in range(21,29):
			for j in range(96,99):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)

				self.failIf(operadora != "VIVO" )
				


class QueOperadora_MG_Tests(unittest.TestCase):				

	def testCLARO(self):
		for ddd in range(31,39):
			for j in range(81,85):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)

				self.failIf(operadora != "CLARO" )		
				
	def testOI(self):
		for ddd in range(31,39):
			for j in range(85,90):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)

				self.failIf(operadora != "OI" )

	def testTIM(self):
		for ddd in range(31,39):
			for j in range(91,95):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)

				self.failIf(operadora != "TIM" )		

	def testVIVO(self):
		for ddd in range(31,39):
			for j in range(95,100):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)

				self.failIf(operadora != "VIVO" )


class QueOperadora_SC_Tests(unittest.TestCase):
	
	def testTIM_1(self):
		cel = "43 81"
		operadora = q.queOperadora(cel)

		self.failIf(operadora != 'TIM')
		
	def testSERCOMTEL(self):
		for i in range(9941,9999):
			cel = "43 %s" % i
			operadora = q.queOperadora(cel)
			
			self.failIf(operadora != 'SERCOMTEL')
			
	def testOI(self):
		for ddd in range(41,50):
			for j in range(84,86):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)
				
				self.failIf(operadora != "OI" )
				
	def testCLARO(self):
		for ddd in range(41,50):
			for j in range(87,89):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)
				
				self.failIf(operadora != "CLARO" )
				
	def testVIVO(self):
		for ddd in range(41,50):
			for j in range(91,95):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)
				
				self.failIf(operadora != "VIVO" )
				
	def testTIM_2(self):
		for ddd in range(41,50):
			for j in range(96,100):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)
				
				self.failIf(operadora != "TIM")
		
class QueOperadora_RS_Tests(unittest.TestCase):				

	def testTIM_PELOTAS(self):
		for j in range(9911,9921):
			cel = '53 %s' % (j)
			operadora = q.queOperadora(cel)

			self.failIf(operadora != "TIM" )			

	def testTIM(self):
		for ddd in range(51,56):
			for j in range(81,83):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)

				self.failIf(operadora != "TIM" )

	def testOI(self):
		for ddd in range(51,56):
			for j in range(84,86):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)

				self.failIf(operadora != "OI" )

	def testCLARO(self):
		for ddd in range(51,56):
			for j in range(91,95):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)

				self.failIf(operadora != "CLARO" )
				
	def testVIVO(self):
		for ddd in range(51,53):
			for j in range(9500,9911):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)

				self.failIf(operadora != "VIVO" )

			for j in range(9921,10000):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)

				self.failIf(operadora != "VIVO" )
				
				
		
class QueOperadora_CENTROOESTE_Tests(unittest.TestCase):				

	def testCLARO_1(self):
		for ddd in range(61,70):
			for j in range(9551,9560):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)

				self.failIf(operadora != "CLARO" )
	
	def testOI_1(self):
		for ddd in range(61,70):
			cel = '%s 86' % (ddd)
			operadora = q.queOperadora(cel)

			self.failIf(operadora != "OI" )
			
	def testTIM(self):
		for ddd in range(61,70):
			for j in range(81,83):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)

				self.failIf(operadora != "TIM" )

	def testOI_2(self):
		for ddd in range(61,70):
			for j in range(84,86):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)

				self.failIf(operadora != "OI" )

	def testCLARO_2(self):
		for ddd in range(61,70):
			for j in range(91,95):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)

				self.failIf(operadora != "CLARO" )

	def testVIVO(self):
		for ddd in range(61,70):
			for j in range(96,100):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)

				self.failIf(operadora != "VIVO" )




class QueOperadora_BA_Tests(unittest.TestCase):				

	def testCLARO(self):
		for ddd in range(71,80):
			for j in range(81,84):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)

				self.failIf(operadora != "CLARO" )

	def testOI(self):
		for ddd in range(71,80):
			for j in range(86,89):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)

				self.failIf(operadora != "OI" )

	def testTIM(self):
		for ddd in range(71,80):
			for j in range(91,95):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)

				self.failIf(operadora != "TIM" )

	def testVIVO(self):
		for ddd in range(71,80):
			for j in range(96,100):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)

				self.failIf(operadora != "VIVO" )


class QueOperadora_NORDESTE_Tests(unittest.TestCase):				

	def testOI_1(self):
		for ddd in range(81,90):
			for j in range(84,87):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)

				self.failIf(operadora != "OI" )

	def testTIM_1(self):
		for ddd in range(81,90):
			for j in range(8719,8722):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)

				self.failIf(operadora != "TIM" )



	def testVIVO(self):
		for ddd in range(81,90):
			for j in range(81,84):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)

				self.failIf(operadora != "VIVO" )
	

	def testOI_2(self):
		for ddd in range(81,90):
			for j in range(87,89):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)

				self.failIf(operadora != "OI" )

	
	def testCLARO(self):
		for ddd in range(81,90):
			for j in range(91,95):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)

				self.failIf(operadora != "CLARO" )


	def testTIM_3(self):
		for ddd in range(81,90):
			for j in range(96,100):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)

				self.failIf(operadora != "TIM" )

class QueOperadora_NORTE_Tests(unittest.TestCase):				

	def testOI_1(self):
		for ddd in range(91,100):
			for j in range(80,84):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)

				self.failIf(operadora != "OI" )	

	def testCLARO(self):
		for ddd in range(91,100):
			cel = '%s 84' % (ddd)
			operadora = q.queOperadora(cel)

			self.failIf(operadora != "CLARO" )

	def testOI_2(self):
		for ddd in range(91,100):
			for j in range(87,89):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)

				self.failIf(operadora != "OI" )

	def testVIVO(self):
		for ddd in range(91,100):
			for j in range(91,95):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)

				self.failIf(operadora != "VIVO" )

	def testAMAZONIACELULAR(self):
		for ddd in range(91,100):
			for j in range(96,100):
				cel = '%s %s' % (ddd, j)
				operadora = q.queOperadora(cel)

				self.failIf(operadora != "OI" )

if __name__ == '__main__':
	unittest.main()

		

