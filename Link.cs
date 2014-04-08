using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DivisorURL
{
    class Link
    {

                      private String url;
                private String protocolo;
                private String dominio;
                private String ruta;

                public Link(String s)
                    {
                    this.url=s;
                    }
        
                public void Separa()
                {


                    String[] arr;
                    if(url.Contains("//"))
                    {
                        arr = Regex.Split(url, ":");
                        this.protocolo = arr[0];
                        arr = Regex.Split(arr[1], "//");
                        arr = Regex.Split(arr[1], "/");
                        this.dominio = arr[0];
                        this.ruta = "";

                        for(int i =1;i<=arr.Length-1;i++)
                        {
                            this.ruta += "/" +arr[i];
                        }


                    }
                    else
                    {
                        if(url.Contains("/"))
                            {
                                arr= Regex.Split(url,"/");
                                this.protocolo= "NO HAY PROTOCOLO";
                                this.dominio= arr[0];
                                this.ruta="";
                                    for (int i = 1; i <=arr.Length; i++)
			                                    {
			                                        this.ruta+="/"+arr[i];
			                                    }

                            }
                            else 
                            {
                                this.dominio= this.url;
                                this.protocolo="NO HAY PROTOCOLO";
                                this.ruta="NO HAY RUTA";
                            }


                                           // return protocolo;


                    }
                }

              public String getUrl() 
              {
                return url;
              }

                public String getProtocolo() 
                {
                    return protocolo;
                }

                public String getDominio()
                {
                    return dominio;
                }

                public String getRuta() 
                {
                    return ruta;
                }
              



    }

}
