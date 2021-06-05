using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Collections;
using System.Collections.Generic;

public class GameData : MonoBehaviour
{
    public int state;
    public int maxGoals = 5;
    public int numPlayers = 10;
    public int countParts = 3;
    [SerializeField] List<int> integers = new List<int>();
    private TcpListener tcpListener; 
	private Thread tcpListenerThread;  	
	private TcpClient connectedTcpClient; 	
	private string clientMessage;

    public static GameData gameData;

    private void Start()
    {
        tcpListenerThread = new Thread (new ThreadStart(recibir)); 		
		tcpListenerThread.IsBackground = true; 		
		tcpListenerThread.Start(); 
    }

    public void Awake()
    {
        if (gameData == null)
        {
            gameData = this;
            DontDestroyOnLoad(gameObject);
        } 
        
        else if (gameData != this)
        {
            Destroy(gameObject);
        }
    }


    int getMaxGoals()
    {
        return maxGoals;
    }
    
    int getNumPlayers()
    {
        return numPlayers;
    }
    
    int getCountParts()
    {
        return countParts;
    }    

    void setCountParts(int value)
    {
        countParts = value;
    }    

    void setNumPlayers(int value)
    {
        numPlayers = value;
    }    

    void setMaxGoals(int value)
    {
        maxGoals = value;
    }


    public void enviar(string text)
    {
        
        byte[] buffer = Encoding.Default.GetBytes(text);


        Socket Enviar = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        IPEndPoint connect = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 10000);
        
        Enviar.Connect(connect);
        Enviar.Send(buffer);
        
    }


    ///<summary>
    /// Escucha mensajes del servidor por medio de sockets
    ///</summary>
    public void recibir () {	
		try { 			
			// Create listener on localhost port 10500. 			
			tcpListener = new TcpListener(IPAddress.Parse("127.0.0.1"), 10500); 			
			tcpListener.Start();              
			Debug.Log("Server is listening");              
			byte[] bytes = new byte[1024];  			
			while (true) { 				
				using (connectedTcpClient = tcpListener.AcceptTcpClient()) { 					
					// Get a stream object for reading				
					using (NetworkStream stream = connectedTcpClient.GetStream()) { 						
						int length;
						// Read incomming stream into byte arrary. 						
						while ((length = stream.Read(bytes, 0, bytes.Length)) != 0) {
							// Convert byte array to string message. 							
							clientMessage = Encoding.ASCII.GetString(bytes);

                            if(state==1){

                            } else if(state==2){
                                toList(clientMessage);
                            }

						}
					} 
				}
			}
		}
		catch (SocketException socketException) { 			
			Debug.Log("SocketException " + socketException.ToString()); 		
		}     
	
    }
    
    public void toList(string text){

        
        bool guardar = false;
        string temp = "";

        for(int i = 0; i<text.Length; i++){
            Debug.Log(text[i] + " y temp " + temp);

            if(text[i]=='[' && !guardar){
                guardar = true;

            } else if(guardar){
                if(text[i]!=',' && text[i]!=']'){
                    temp += text[i].ToString();

                } else if(text[i]==','){
                    integers.Add(int.Parse(temp));
                    temp="";

                } else if(text[i]==']'){
                    integers.Add(int.Parse(temp));
                    temp="";
                    guardar=false;
                    break;
                }
            }
        }
    }
}
