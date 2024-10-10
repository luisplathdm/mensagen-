using Manager;

namespace FlapPlathpus;
public partial class MainPage : ContentPage
{
	const int gravity = 5; 
	// a gravidade que vai ser aplicada no objeto
	const int TimeToCan = 100; // e disso tbm

	const int TimeToFrame = 8; 
	//tempo de espera dos frames ou fps
	const int jumpHeight = 100;
	//o tanto que o passsaro pulaa

	bool isDead = false; 
	// Óbvio que é quando o passaro cai pelo cano

	bool IsEnd = false; // sem esquecer disso 


//---------------------------------------------------------------------------------------//
	
	public MainPage()
	{
		InitializeComponent(); 
	}


//---------------------------------------------------------------------------------------//
    async Task Drawn()
	{
		while(!isDead) 
		// !=não, enquanto não está morto aplica gravidade
		
		while(!IsEnd)
		
		
		{
			IntroGravity();
			await Task.Delay(TimeToFrame);
		    // como esse é o tempo de espra entre os frames 
			
			IntroTimeToCan(); //isso aqui 
			await Task.Delay(TimeToFrame); //isso aqui tbm 
		}
	}

//---------------------------------------------------------------------------------------//
    
	async void IntroGravity()
	{
		Imgperry.TranslationY += gravity; 
		// translation é a transiçao do eixo Y ou x no caso como aumenta
		//é oque vai fazer o pasarinho cair 
		                                      
	}

   async void IntroTimeToCan() //isso tudo aqui tbm
   {
	Imgcanocima.TranslationX -= gravity;
	Imgcanobaixo.TranslationX -= gravity;
			if (Imgcanocima.TranslationX <= -Imgcanocima.Width || Imgcanobaixo.TranslationX <= -Imgcanobaixo.Width)
		{
			// Redefine a posição dos canos para fora da tela à direita
			double screenWidth = Application.Current.MainPage.Width;
			Imgcanocima.TranslationX = screenWidth + Imgcanocima.Width; // Coloca o cano à direita da tela
			Imgcanobaixo.TranslationX = screenWidth + Imgcanobaixo.Width; // Coloca o cano à direita da tela
		}
	
   }
//---------------------------------------------------------------------------------------//
	
	void OnScreenTapped(object sender, EventArgs e)
	{
		// Faz o pássaro subir um pouco ao clicar
		Imgperry.TranslationY -= jumpHeight; 
		// Subtrair diminui o Y, fazendo o pássaro subir
	}
	protected override void OnAppearing()
	{
		base.OnAppearing();
		Drawn();
		//faz ele rodar de forma sincrona ou junto com a pagina
	}
	
//---------------------------------------------------------------------------------------//
}





