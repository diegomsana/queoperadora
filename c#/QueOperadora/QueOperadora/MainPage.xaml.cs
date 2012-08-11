using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Microsoft.Phone.Controls;
using task = Microsoft.Phone.Tasks;
using System.Windows.Media.Imaging;
using Microsoft.Phone.UserData;

namespace QueOperadora
{
	public partial class MainPage : PhoneApplicationPage
	{
		/// <summary>
		/// Para chamar a tela de salvar contatos
		/// </summary>
		task.SaveContactTask c_saveContactTask;

		/// <summary>
		/// Para chamar a tela de ligação
		/// </summary>
		task.PhoneCallTask c_phoneCallTask;

		/// 
		/// Constructor
		/// 
		public MainPage( )
		{
			InitializeComponent( );

			c_phoneCallTask = new task.PhoneCallTask( );

			c_saveContactTask = new task.SaveContactTask( );
			c_saveContactTask.Completed += new EventHandler<task.SaveContactResult>( saveContactTask_Completed );
		}

		/// 2012 05 19 - Césare
		/// <summary>
		/// Capturando o evento após completar a ação de adicionar contato
		/// </summary>
		void saveContactTask_Completed( object sender, task.SaveContactResult e )
		{
			if( e.TaskResult == task.TaskResult.OK )
				MessageBox.Show( "Contato salvo!", "Atenção", MessageBoxButton.OK );
		}

		/// 2012 05 19 - Césare
		/// <summary>
		/// Verificando qual a operadora do celular que o usuário digitou
		/// </summary>
		private void txt_numeroCelular_KeyUp( object sender, KeyEventArgs e )
		{
			cm_ValidaCaracteresInvalidos( ( TextBox )sender );

			Class.Operadora m_operadora = new Class.Operadora( );
			string m_retorno = m_operadora.CM_QueOperadora( txt_numeroCelular.Text );

			switch( m_retorno )
			{
				case "TIM":
					BitmapImage m_tim = new BitmapImage( new Uri( "Images/tim.png", UriKind.RelativeOrAbsolute ) );
					img_operadora.Source = m_tim;

					break;
				case "VIVO":
					BitmapImage m_vivo = new BitmapImage( new Uri( "Images/vivo.png", UriKind.RelativeOrAbsolute ) );
					img_operadora.Source = m_vivo;

					break;
				case "CLARO":
					BitmapImage m_claro = new BitmapImage( new Uri( "Images/claro.png", UriKind.RelativeOrAbsolute ) );
					img_operadora.Source = m_claro;

					break;
				case "OI":
					BitmapImage m_oi = new BitmapImage( new Uri( "Images/oi.jpg", UriKind.RelativeOrAbsolute ) );
					img_operadora.Source = m_oi;

					break;
				case "CTBC":
					BitmapImage m_ctbc = new BitmapImage( new Uri( "Images/ctbc.png", UriKind.RelativeOrAbsolute ) );
					img_operadora.Source = m_ctbc;

					break;
				case "SERCOMTEL":
					BitmapImage m_sercomtel = new BitmapImage( new Uri( "Images/sercomtel.gif", UriKind.RelativeOrAbsolute ) );
					img_operadora.Source = m_sercomtel;

					break;
				default:
					BitmapImage m_nenhuma = new BitmapImage( new Uri( "Images/nenhuma.png", UriKind.RelativeOrAbsolute ) );
					img_operadora.Source = m_nenhuma;

					break;
			}
		}

		/// <summary>
		/// Remove os caracteres inválidos
		/// </summary>
		/// <param name="p_textBox">O textBox a ser verificado</param>
		private void cm_ValidaCaracteresInvalidos( TextBox p_textBox )
		{
			string[ ] m_caracteresInvalidos = { "." };

			for( int i = 0; i < m_caracteresInvalidos.Length; i++ )
			{
				p_textBox.Text = p_textBox.Text.Replace( m_caracteresInvalidos[ i ], "" );
			}

			p_textBox.SelectionStart = p_textBox.Text.Length;
		}

		/// <summary>
		/// Salvando caracteres inválidos
		/// </summary>
		private void txt_numeroCelular_KeyDown( object sender, KeyEventArgs e )
		{
			cm_ValidaCaracteresInvalidos( ( TextBox )sender );
		}

		/// 2012 05 19 - Césare
		/// <summary>
		/// Vamos adicionar aos contatos o número digitado pelo usuário
		/// </summary>
		private void salvarContato_Click( object sender, EventArgs e )
		{
			c_saveContactTask.MobilePhone = txt_numeroCelular.Text;
			c_saveContactTask.Show( );
		}

		/// 2012 07 14 - Césare
		/// <summary>
		/// Vamos ligar para o contato digitado
		/// </summary>
		private void ligar_Click( object sender, EventArgs e )
		{
			c_phoneCallTask.PhoneNumber = txt_numeroCelular.Text;
			c_phoneCallTask.Show( );
		}
	}
}