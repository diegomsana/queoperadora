using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using QueOperadora.Class;

namespace QueOperadoraUnitTest.Class
{
	[TestFixture]
	public class TestBA
	{
		QueOperadora.Class.Operadora m_operadora = new Operadora( );

		[Test]
		public void TestClaro( )
		{
			for( int i = 71; i < 80; i++ )
			{
				for( int j = 81; j < 84; j++ )
				{
					string m_cel = i.ToString( ) + j.ToString( );

					string m_opera = m_operadora.CM_QueOperadora( m_cel );

					Assert.AreEqual( "CLARO", m_opera );	
				}
			}
		}

		[Test]
		public void TestOi( )
		{
			for( int i = 71; i < 80; i++ )
			{
				for( int j = 86; j < 89; j++ )
				{
					string m_cel = i.ToString( ) + j.ToString( );

					string m_opera = m_operadora.CM_QueOperadora( m_cel );

					Assert.AreEqual( "OI", m_opera );
				}
			}
		}

		[Test]
		public void TestTim( )
		{
			for( int i = 71; i < 80; i++ )
			{
				for( int j = 91; j < 95; j++ )
				{
					string m_cel = i.ToString( ) + j.ToString( );

					string m_opera = m_operadora.CM_QueOperadora( m_cel );

					Assert.AreEqual( "TIM", m_opera );
				}
			}
		}

		[Test]
		public void TestVivo( )
		{
			for( int i = 71; i < 80; i++ )
			{
				for( int j = 96; j < 100; j++ )
				{
					string m_cel = i.ToString( ) + j.ToString( );

					string m_opera = m_operadora.CM_QueOperadora( m_cel );

					Assert.AreEqual( "VIVO", m_opera );
				}
			}
		}
	}
}
