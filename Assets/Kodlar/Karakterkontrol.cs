using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Karakterkontrol : MonoBehaviour
{
    public Sahneler sh;
    public Sagtus sagbut;
    public Soltus solbut;
    public Ziplakont ziplabut;
    public Klon klon;
    public Pause pas;
    public float randomFloat;
    public Rigidbody rg;
    public RaycastHit hit1;
    public Transform karakter;
    public Animator karakteranim;
    public bool ziplabool = false,danshareketi=false,engelkaldir=false,ismagnet=false,kilitlifare=false,kilitlidozzy=false,kilitliguresci=false,kilitlikadin=false,kilitlibuyucu=false,kilitlitavuk=false;
    public Transform yol1, yol2;
    public Vector3 newpos;
    public GameObject gobuton,ganimettxt,gameover,ipucu,efekt,artibes,bip,kilitf,kilitk,kilitg,kilitd,kilitb,kilitt,touchbutn,gbonuspnl, gbonuspnl1,coinanim;
    public int altinsayisi = 0,deger=0,degerfare,degerdozzy,degerkadin,degerguresci,degertavuk,degerbuyucu;
    public int coinsayisi = 0;
    public Text altintext,skortxt,cointxt;
    public Text sayacText;
    public float saniye, dakika,saat;

    void Start()
    {
        deger = 0;
        degerbuyucu = 0;
        degerdozzy = 0;
        degerfare = 0;
        degerguresci = 0;
        degerkadin = 0;
        degertavuk = 0;
        deger = PlayerPrefs.GetInt("deger");
        degerfare = PlayerPrefs.GetInt("degerfare");
        degerbuyucu = PlayerPrefs.GetInt("degerbuyucu");
        degertavuk = PlayerPrefs.GetInt("degertavuk");
        degerguresci = PlayerPrefs.GetInt("degerguresci");
        degerdozzy = PlayerPrefs.GetInt("degerdozzy");
        saat = PlayerPrefs.GetFloat("saat");
        dakika = PlayerPrefs.GetFloat("dakika");
        saniye = PlayerPrefs.GetFloat("saniye");
        coinsayisi = PlayerPrefs.GetInt("coinsayisi");
        randomFloat = Random.Range(17.4f, 22.21f);
        karakteranim = GetComponent<Animator>();
        rg.GetComponent<Rigidbody>();
        ganimettxt.gameObject.SetActive(false);
        gameover.gameObject.SetActive(false);
        
    }

   

    private void Awake()
    {
        karakter = transform;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "yol1")
        {
            yol1.transform.position = new Vector3(yol2.transform.position.x, yol2.transform.position.y, yol2.transform.position.z+10);
            
        }
        if (other.gameObject.tag == "yol2")
        {
            yol2.transform.position = new Vector3(yol1.transform.position.x, yol1.transform.position.y, yol1.transform.position.z + 10);
        }
        
        
        


    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "danceicon")
        {
            
            danshareketi = true;
            karakteranim.SetBool("dans", true);
            Invoke("DansEtmek", 5.0f);
            Destroy(collision.gameObject);
            ismagnet = true;
            efekt.gameObject.SetActive(true);
            artibes.gameObject.SetActive(true);
            Altintoplama();
        }
        if (collision.gameObject.tag == "engel")
        {
            ziplabut.harekett = false;
            gameover.gameObject.SetActive(true);
            karakteranim.SetBool("olum", true);
        }
        if (collision.gameObject.tag == "gitar")
        {
            bip.gameObject.SetActive(true);
            Invoke("BipSesi", 0.2f);
            Destroy(collision.gameObject);
            Altintoplama();
            skortxt.text = "Puan : " + altinsayisi;
        }
    }
    
    public void DansEtmek()
    {
        
        danshareketi = false;
        ismagnet = false;
        efekt.gameObject.SetActive(false);
        artibes.gameObject.SetActive(false);
    }
    public void BipSesi()
    {
        bip.gameObject.SetActive(false);
    }
    public void Altintoplama()
    {
        if (ismagnet == true)
        {
            altinsayisi += 5;
            altintext.text = "Ganimet : " + altinsayisi;
        }
        if (ismagnet == false)
        {
            altinsayisi += 1;
            altintext.text = "Ganimet : " + altinsayisi;
        }

        if (altinsayisi == 30)
        {
            coinsayisi += 50;
            CoinGüncelle();
        }
        if (altinsayisi ==50)
        {
            coinsayisi += 60;
            CoinGüncelle();
        }

    }
    public void CoinGüncelle()
    {
        if (coinsayisi < 0)
        {
            coinsayisi = 0;
        }
        PlayerPrefs.SetInt("coinsayisi", coinsayisi);
        //cointxt.text = PlayerPrefs.GetInt("").ToString();
        cointxt.text = coinsayisi.ToString();
        //PlayerPrefs.Save();
    }
    
    public void Gbonus()
    {
        coinsayisi =coinsayisi+50;
        CoinGüncelle();
        deger = 1;
        saniye = 30;
        dakika = 30;
        saat = 5;
        coinanim.gameObject.SetActive(true);
        Invoke("Yoket", 0.7f);
        
    }
    public void Yoket()
    {
        coinanim.gameObject.SetActive(false);
    }
    public void GerisayimGbonus()
    {
        saniye -= Time.deltaTime;
        if (Mathf.RoundToInt(saniye) < 0)
        {
            saniye = 59;
            
            dakika-=1;
        }
        if (Mathf.RoundToInt(dakika) < 0)
        {
            dakika = 59;
            saat-=1;
        }
        
        sayacText.text = Mathf.RoundToInt(saat).ToString("D2") + ":" + Mathf.RoundToInt(dakika).ToString("D2") + ":" + Mathf.RoundToInt(saniye).ToString("D2");
        if (saat == 0) 
        {
            deger = 0;
            gbonuspnl.gameObject.SetActive(false);
        }
        PlayerPrefs.SetFloat("saat", saat);
        PlayerPrefs.SetFloat("dakika", dakika);
        PlayerPrefs.SetFloat("saniye", saniye);
    }
    
    public void Kilitkaldir()
    {
        if (cointxt.text=="150")
        {
            kilitlifare = false;
            kilitf.gameObject.SetActive(false);
        }
        if (cointxt.text == "250")
        {
            kilitlikadin = false;
            kilitk.gameObject.SetActive(false);

        }
        if (cointxt.text == "300")
        {
            kilitlidozzy = false;
            kilitd.gameObject.SetActive(false);

        }
        if (cointxt.text == "400")
        {
            kilitlibuyucu = false;
            kilitb.gameObject.SetActive(false);

        }
        if (cointxt.text == "550")
        {
            kilitliguresci = false;
            kilitg.gameObject.SetActive(false);

        }
        if (cointxt.text == "700")
        {
            kilitlitavuk = false;
            kilitt.gameObject.SetActive(false);

        }
    }
    void Update()
    {
        CoinGüncelle();
        GerisayimGbonus();
        Kilitkaldir();
        if (ziplabut.harekett == true)
        {

            ipucu.gameObject.SetActive(false);
            gobuton.gameObject.SetActive(false);
            touchbutn.gameObject.SetActive(false);
            ganimettxt.gameObject.SetActive(true);
                
                if (!danshareketi)
                {

                    karakteranim.SetBool("hareket", true);
                    karakteranim.SetBool("dans", false);

                    if (ziplabut.ziplamak==true)
                    {
                        
                        rg.velocity = Vector3.up * 300.0f * Time.deltaTime;
                        

                    }
                    if(pas.durak == false)
                    {
                        transform.Translate(0, 0, 3.2f * Time.deltaTime);
                    
                    }
                    
                
                    if (sagbut.sag)
                    {
                        transform.position = Vector3.Lerp(transform.position, new Vector3(0.682f, transform.position.y, transform.position.z), Time.deltaTime * 5.0f);
                    }
                    if (ziplabut.ziplamak)
                    {
                    transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, 0.709f, transform.position.z), Time.deltaTime * 5.0f);
                    }
                    if (solbut.sol==true)
                    {
                        transform.position = Vector3.Lerp(transform.position, new Vector3(-0.645f, transform.position.y, transform.position.z), Time.deltaTime * 5.0f);
                    }
                }
            
        }
        if (sh.eksi == true)
        {

            coinsayisi -= 150;
            CoinGüncelle();
            degerfare = 1;
            PlayerPrefs.SetInt("degerfare", degerfare);
        }
        if (sh.eksik == true)
        {
            coinsayisi -= 250;
            CoinGüncelle();
            degerkadin = 1;
            PlayerPrefs.SetInt("degerkadin", degerkadin);
        }
        if (sh.eksid == true)
        {
            coinsayisi -= 300;
            CoinGüncelle();
            degerdozzy = 1;
            PlayerPrefs.SetInt("degerdozzy", degerdozzy);
        }
        if (sh.eksib == true)
        {
            coinsayisi -= 400;
            CoinGüncelle();
            degerbuyucu = 1;
            PlayerPrefs.SetInt("degerbuyucu", degerbuyucu);
        }
        if (sh.eksig == true)
        {
            coinsayisi -= 550;
            CoinGüncelle();
            degerguresci = 1;
            PlayerPrefs.SetInt("degerguresci", degerguresci);
        }
        if (sh.eksit == true)
        {
            coinsayisi -= 700;
            CoinGüncelle();
            degertavuk = 1;
            PlayerPrefs.SetInt("degertavuk", degertavuk);
        }
        PlayerPrefs.SetInt("deger", deger);
        if (deger==1)
        {
            gbonuspnl.gameObject.SetActive(true);
        }
        else
        {
            gbonuspnl.gameObject.SetActive(false);
        }
        if (degerfare == 1)
        {
            kilitlifare = false;
            kilitf.gameObject.SetActive(false);
        }
        if (degerkadin == 1)
        {
            kilitlikadin = false;
            kilitk.gameObject.SetActive(false);
        }
        if (degerdozzy == 1)
        {
            kilitlidozzy = false;
            kilitd.gameObject.SetActive(false);
        }
        if (degerbuyucu == 1)
        {
            kilitlibuyucu = false;
            kilitb.gameObject.SetActive(false);
        }
        if (degerguresci == 1)
        {
            kilitliguresci = false;
            kilitg.gameObject.SetActive(false);
        }
        if (degertavuk == 1)
        {
            kilitlitavuk = false;
            kilitt.gameObject.SetActive(false);
        }
    }
    
}
