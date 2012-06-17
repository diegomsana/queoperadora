using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using QueOperadora.Class;

namespace QueOperadoraUnitTest.Class
{
	[TestFixture]
	public class TestRJ
	{
		QueOperadora.Class.Operadora m_operadora = new Operadora( );

		[Test]
		public void TestVivo1( )
		{
			for( int i = 21; i < 29; i++ )
			{
				string m_cel = i.ToString( ) + "71";

				string m_opera = m_operadora.CM_QueOperadora( m_cel );

				Assert.AreEqual( "VIVO", m_opera );
			}
		}

		[Test]
		public void TestVivo2( )
		{
			for( int i = 21; i < 29; i++ )
			{
				string m_cel = i.ToString( ) + "72";

				string m_opera = m_operadora.CM_QueOperadora( m_cel );

				Assert.AreEqual( "VIVO", m_opera );
			}
		}

		[Test]
		public void TestVivo3( )
		{
			for( int i = 21; i < 29; i++ )
			{
				string m_cel = i.ToString( ) + "95";

				string m_opera = m_operadora.CM_QueOperadora( m_cel );

				Assert.AreEqual( "VIVO", m_opera );
			}
		}

		[Test]
		public void TestClaro1( )
		{
			for( int i = 21; i < 29; i++ )
			{
				for( int j = 74; j < 77; j++ )
				{
					string m_cel = i.ToString( ) + j.ToString( );

					string m_opera = m_operadora.CM_QueOperadora( m_cel );

					Assert.AreEqual( "CLARO", m_opera );
				}
			}
		}

		[Test]
		public void TestTim( )
		{
			for( int i = 21; i < 29; i++ )
			{
				for( int j = 80; j < 84; j++ )
				{
					string m_cel = i.ToString( ) + j.ToString( );

					string m_opera = m_operadora.CM_QueOperadora( m_cel );

					Assert.AreEqual( "TIM", m_opera );
				}
			}
		}

		[Test]
		public void TestOi1( )
		{
			for( int i = 21; i < 29; i++ )
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
		public void TestOi2( )
		{
			for( int i = 21; i < 29; i++ )
			{
				for( int j = 87; j < 90; j++ )
				{
					string m_cel = i.ToString( ) + j.ToString( );

					string m_opera = m_operadora.CM_QueOperadora( m_cel );

					Assert.AreEqual( "OI", m_opera );
				}
			}
		}

		[Test]
		public void TestClaro2( )
		{
			for( int i = 21; i < 29; i++ )
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
		public void TestVivo4( )
		{
			for( int i = 21; i < 29; i++ )
			{
				for( int j = 96; j < 99; j++ )
				{
					string m_cel = i.ToString( ) + j.ToString( );

					string m_opera = m_operadora.CM_QueOperadora( m_cel );

					Assert.AreEqual( "VIVO", m_opera );
				}
			}
		}
	}
}
