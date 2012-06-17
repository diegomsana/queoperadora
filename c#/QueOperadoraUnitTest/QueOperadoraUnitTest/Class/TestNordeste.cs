using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using QueOperadora.Class;

namespace QueOperadoraUnitTest.Class
{
	[TestFixture]
	public class TestNordeste
	{
		QueOperadora.Class.Operadora m_operadora = new Operadora( );

		[Test]
		public void TestOi1( )
		{
			for( int i = 81; i < 90; i++ )
			{
				for( int j = 84; j < 87; j++ )
				{
					string m_cel = i.ToString( ) + j.ToString( );

					string m_opera = m_operadora.CM_QueOperadora( m_cel );

					Assert.AreEqual( "OI", m_opera );
				}
			}
		}

		[Test]
		public void TestTim1( )
		{
			for( int i = 81; i < 90; i++ )
			{
				for( int j = 8719; j < 8722; j++ )
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
			for( int i = 81; i < 90; i++ )
			{
				for( int j = 81; j < 84; j++ )
				{
					string m_cel = i.ToString( ) + j.ToString( );

					string m_opera = m_operadora.CM_QueOperadora( m_cel );

					Assert.AreEqual( "VIVO", m_opera );
				}
			}
		}

		[Test]
		public void TestOi2( )
		{
			for( int i = 81; i < 90; i++ )
			{
				for( int j = 87; j < 89; j++ )
				{
					string m_cel = i.ToString( ) + j.ToString( );

					string m_opera = m_operadora.CM_QueOperadora( m_cel );

					Assert.AreEqual( "OI", m_opera );
				}
			}
		}

		[Test]
		public void TestClaro( )
		{
			for( int i = 81; i < 90; i++ )
			{
				for( int j = 91; j < 95; j++ )
				{
					string m_cel = i.ToString( ) + j.ToString( );

					string m_opera = m_operadora.CM_QueOperadora( m_cel );

					Assert.AreEqual( "CLARO", m_opera );
				}
			}
		}

		[Test]
		public void TestTim3( )
		{
			for( int i = 81; i < 90; i++ )
			{
				for( int j = 96; j < 100; j++ )
				{
					string m_cel = i.ToString( ) + j.ToString( );

					string m_opera = m_operadora.CM_QueOperadora( m_cel );

					Assert.AreEqual( "TIM", m_opera );
				}
			}
		}
	}
}
