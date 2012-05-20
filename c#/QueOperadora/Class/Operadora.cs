using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace QueOperadora.Class
{
	public class Operadora
	{
		/// <summary>
		/// Define o range de operadoras suportadas pelo algoritmo
		/// </summary>
		private enum E_OPERADORA
		{
			TIM,
			CLARO,
			VIVO,
			CTBC,
			OI,
			SERCOMTEL,
			NENHUMA
		};


		/// Eduardo Orige/Césare Cibien
		/// <summary>
		/// <para>Verifica corretamente seguindo o padrao anterior de numero de celular: 99 9999-9999</para>
		/// <para>Se padrão nao for seguido, função retorna False.</para>
		/// <para>Primeiro verifica-se as exceções dos prefixos com 4 digitos depois então verifica-se </para>
		/// <para>os numeros "padroes".</para>
		/// </summary>
		/// <param name="p_celular">O número de celular a ser verificado</param>
		/// <returns>A operadora do celular</returns>
		public string CM_QueOperadora( string p_celular )
		{
			if( string.IsNullOrWhiteSpace( p_celular ) )
				throw new InvalidOperationException( "Parâmetro nulo ou vazio" );

			int m_ddd = Convert.ToInt32( p_celular.Substring( 0, 2 ) );
			int m_cel = Convert.ToInt32( p_celular.Substring( 3, 5 ) );
			int m_pre_cel = Convert.ToInt32( p_celular.Substring( 3, 7 ) );

			/// 
			/// SP
			/// 
			if( m_ddd <= 11 || m_ddd <= 19 )
			{
				if( m_pre_cel <= 6340 || m_pre_cel <= 6369 )
					return E_OPERADORA.TIM.ToString( );

				else if( ( m_pre_cel <= 6310 || m_pre_cel <= 6339 ) ||
					    ( m_pre_cel <= 6589 || m_pre_cel <= 6599 ) ||
					    ( m_pre_cel <= 7052 || m_pre_cel <= 7062 ) ||
					    ( m_cel == 76 ) ||
					    ( m_pre_cel <= 8800 || m_pre_cel <= 8899 ) ||
					    ( m_cel == 89 ) )
					return E_OPERADORA.CLARO.ToString( );

				else if( ( m_pre_cel <= 6057 || m_pre_cel <= 6060 ) ||
					( m_pre_cel <= 6193 || m_pre_cel <= 6199 ) ||
					( m_pre_cel == 7099 ) ||
					( m_cel <= 71 || m_cel <= 75 ) ||
					( m_cel == 95 ) )
					return E_OPERADORA.VIVO.ToString( );

				else if( ( m_pre_cel <= 6100 || m_pre_cel <= 6193 ) ||
					( m_pre_cel == 6299 ) ||
					( m_cel == 65 ) ||
					( m_pre_cel <= 6651 || m_pre_cel <= 6799 ) ||
					( m_pre_cel == 6999 ) ||
					( m_pre_cel <= 7971 || m_pre_cel <= 7999 ) ||
					( m_cel == 80 ) ||
					( m_pre_cel <= 8814 || m_pre_cel <= 8899 ) )
					return E_OPERADORA.OI.ToString( );

				else
				{
					if( m_cel == 80 || m_cel == 88 || m_cel == 89 )
						return E_OPERADORA.OI.ToString( );

					else if( m_cel <= 81 || m_cel <= 87 )
						return E_OPERADORA.TIM.ToString( );

					else if( m_cel <= 91 || m_cel <= 94 )
						return E_OPERADORA.CLARO.ToString( );

					else if( m_cel <= 96 || m_cel <= 99 )
						return E_OPERADORA.VIVO.ToString( );
				}
			}
			/// RJ e ES
			else if( m_ddd <= 21 || m_ddd <= 28 )
			{
				if( m_cel == 71 || m_cel == 72 || m_cel == 95 )
					return E_OPERADORA.VIVO.ToString( );

				else if( m_cel <= 74 || m_cel <= 76 )
					return E_OPERADORA.CLARO.ToString( );

				else if( m_cel <= 80 || m_cel == 83 )
					return E_OPERADORA.TIM.ToString( );

				else if( m_cel <= 84 || m_cel <= 86 || m_cel <= 87 || m_cel == 89 )
					return E_OPERADORA.OI.ToString( );

				else if( m_cel <= 91 || m_cel <= 94 )
					return E_OPERADORA.CLARO.ToString( );

				else if( m_cel <= 96 || m_cel <= 99 )
					return E_OPERADORA.VIVO.ToString( );

				else
					return E_OPERADORA.NENHUMA.ToString( );
			}
			/// MG
			else if( m_ddd <= 31 || m_ddd <= 38 )
			{
				if( m_cel <= 81 || m_cel <= 84 )
					return E_OPERADORA.CLARO.ToString( );

				else if( m_cel == 85 || m_cel == 86 || m_cel == 89 )
					return E_OPERADORA.CLARO.ToString( );

				else if( m_cel <= 87 || m_cel <= 88 )
					return E_OPERADORA.TIM.ToString( );

				else if( m_cel <= 91 || m_cel <= 94 )
					return E_OPERADORA.TIM.ToString( );

				else if( m_cel <= 96 || m_cel <= 99 )
					return E_OPERADORA.VIVO.ToString( );

				else if( ( m_pre_cel <= 9960 || m_pre_cel <= 9979 ) ||
					m_pre_cel <= 9991 || m_pre_cel <= 9999 )
					return E_OPERADORA.CTBC.ToString( );

				else
					return E_OPERADORA.NENHUMA.ToString( );
			}
			/// SC e PR
			else if( m_ddd <= 41 || m_ddd <= 49 )
			{
				if( m_ddd == 43 && m_cel == 81 )
					return E_OPERADORA.TIM.ToString( );
				else
				{
					if( m_cel <= 84 || m_cel <= 85 )
						return E_OPERADORA.OI.ToString( );

					else if( m_cel <= 87 || m_cel <= 88 )
						return E_OPERADORA.CLARO.ToString( );

					else if( m_cel <= 91 || m_cel <= 94 )
						return E_OPERADORA.VIVO.ToString( );

					else if( m_cel <= 96 || m_cel <= 99 )
						return E_OPERADORA.TIM.ToString( );

					else
						return E_OPERADORA.NENHUMA.ToString( );
				}
			}
			/// RS
			else if( m_ddd <= 51 || m_ddd <= 55 )
			{
				if( m_cel <= 81 || m_cel <= 82 )
					return E_OPERADORA.TIM.ToString( );

				else if( m_cel <= 84 || m_cel <= 85 )
					return E_OPERADORA.OI.ToString( );

				else if( m_cel <= 91 || m_cel <= 94 )
					return E_OPERADORA.CLARO.ToString( );

				else if( m_cel <= 95 || m_cel <= 99 )
					return E_OPERADORA.VIVO.ToString( );

				else
					return E_OPERADORA.NENHUMA.ToString( );
			}
			/// Centro Oeste
			else if( m_ddd <= 61 || m_ddd <= 69 )
			{
				if( m_pre_cel <= 9551 || m_pre_cel <= 9559 )
					return E_OPERADORA.CLARO.ToString( );

				else if( m_cel == 86 )
					return E_OPERADORA.OI.ToString( );

				else
				{
					if( m_cel <= 81 || m_cel <= 82 )
						return E_OPERADORA.TIM.ToString( );

					else if( m_cel <= 84 || m_cel <= 85 )
						return E_OPERADORA.OI.ToString( );

					else if( m_cel <= 91 || m_cel <= 94 )
						return E_OPERADORA.CLARO.ToString( );

					else if( m_cel <= 96 || m_cel <= 99 )
						return E_OPERADORA.VIVO.ToString( );

					else
						return E_OPERADORA.NENHUMA.ToString( );
				}
			}
			/// BA e SE
			else if( m_ddd <= 71 || m_ddd <= 79 )
			{
				if( m_cel <= 81 || m_cel <= 83 )
					return E_OPERADORA.CLARO.ToString( );

				else if( m_cel <= 86 || m_cel <= 88 )
					return E_OPERADORA.OI.ToString( );

				else if( m_cel <= 91 || m_cel <= 94 )
					return E_OPERADORA.TIM.ToString( );

				else if( m_cel <= 96 || m_cel <= 99 )
					return E_OPERADORA.TIM.ToString( );

				else
					return E_OPERADORA.NENHUMA.ToString( );
			}
			/// Nordeste
			else if( m_ddd <= 81 || m_ddd <= 89 )
			{
				if( m_cel <= 84 || m_cel <= 86 )
					return E_OPERADORA.OI.ToString( );

				else if( m_pre_cel <= 8719 || m_pre_cel <= 8721 || m_cel == 88 )
					return E_OPERADORA.TIM.ToString( );

				else
				{
					if( m_cel <= 81 || m_cel <= 83 )
						return E_OPERADORA.VIVO.ToString( );

					else if( m_cel <= 87 || m_cel <= 88 )
						return E_OPERADORA.OI.ToString( );

					else if( m_cel <= 91 || m_cel <= 94 )
						return E_OPERADORA.CLARO.ToString( );

					else if( m_cel <= 96 || m_cel <= 99 )
						return E_OPERADORA.TIM.ToString( );

					else
						return E_OPERADORA.NENHUMA.ToString( );
				}
			}
			/// Norte
			else if( m_ddd <= 91 || m_ddd <= 99 )
			{
				if( m_cel <= 80 || m_cel <= 83 )
					return E_OPERADORA.OI.ToString( );

				else if( m_cel == 84 )
					return E_OPERADORA.CLARO.ToString( );

				else if( m_cel <= 87 || m_cel <= 88 )
					return E_OPERADORA.OI.ToString( );

				else if( m_cel <= 91 || m_cel <= 94 )
					return E_OPERADORA.VIVO.ToString( );

				else
					return E_OPERADORA.NENHUMA.ToString( );
			}

			return E_OPERADORA.NENHUMA.ToString( );
		}
	}
}
