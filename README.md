# *Examen Parcial 2*
+ Este repositorio tiene la finalidad de demostrar nuestros conocimientos acerca de Shader graph que se cursó en el segundo parcial de la materia tópicos de física y se usa estrictamente Shader Graph en Unity.
+ Este proyecto se creó a partir de Shader Graph desde un Universal Render Pipeline, el proyecto consiste en recrear el sistema solar, donde se realizaron los planetas, sol y luna con distintos componentes que nos hicieron trabajar los conocimientos de esta materia. Se tomaron en cuenta las medidas, texturas y componentes oficiales de la nasa.
Los planetas tienen como componente su efecto particular de textura, normal map junto con el rim light, cabe destacar que existen componentes extras que se realizaron con otros tipos de técnicas que se brindan en Universal Render Pipeline. 

## Desarrollo 
+ Para la creación de los planetas se creó desde Lit Shader Graph, donde cada planeta llevo distintos pasos y distintos componentes, unos más que otros ya que cada uno cuenta con distintos grados de dificultad. En la creación de los planetas sencillos, los cuales en su mayoría son los que su totalidad es de gas. Estos planetas no necesitaron componentes extras de distintas fuentes, así que se utilizaron los shader básicos para su creación: 
  + ***Main Texture***
  + ***Normal Map***: 
  ![](Normal Map.png)
  + ***Rim Light***:
  ![](RimLight.png)
  + ***Y movimiento en texturas para simular el movimiento constante de planetas***:  
  ![](RotationNormal.png)
  ![](RotationTexture.png)

+ **El Main Texture**, es particularmente para cada planeta, esta representa la textura difusa principal de cada planeta, es lo que nos ayuda a darle al modelo, su textura como capa de imagen para que se adapte al modelo.
Los normal Maps son un tipo de textura especial que nos permitió agregar detalles en las superficies como golpes/bultos/bumps, surcos, rayones a un modelo que atrapa la luz como si fuera representado por una geometría real. La Normal Map se agrega como Texture 2d para que haga complemento junto con la Textura y que nos dé una representación del modelo más realista.

+ La utilización de **Rim Light** puede usar para estilizar o resaltar objetos y favorece mucho ciertos estilos artísticos. Es especialmente agradable cuando se aplica a modelos con curvas suaves y en este caso los planetas se complementaron muy bien con este efecto y nos dio un resultado muy realista.

+ **El movimiento de texturas** se usó para la simulación del movimiento de los planetas, donde se usó el time junto con una variable flotante para multiplicarse y combinarse para después pasar hacia tilling and offset el cual compensa el valor de entrada UV mediante las entradas del tilling and offset el cual se conecta hacia la entrada UV y nos permitió la simulación.

+ **Scripts**
  + **Script ChangeTarget**: en el script ChangeLookAtTarget se declara una variable de tipo GameObject la cual tiene como nombre target, se pregunta si ese target esta vació, si es así se le asigna nuestro GameObject seleccionado, se tiene una función en la cual se pasa una variable del script LookAtTarget y se le cambia el valor del GameObject al que se tiene actualmente y ajustamos la cámara a ese objeto.
  + **LookTarget**: en el script LookAtTarget se declara una variable pública de tipo GameObject, se pregunta si nuestra variable esta vacia, de ser así se le asigna el GameObject en el que nos encontramos. Después se tiene una función la cual hace que la cámara siga a nuestro objeto.
  + **RotateAround**: se tienen dos variables públicas, una para el planeta y otra para la velocidad, primero se pregunta si nuestro planeta esta vació, si es así le asigamos el planeta en el que nos encontramos. Luego en la función Update le indicamos al planeta la posición que va a seguir junto con la velocidad dada anteriormente.

+ Usamos un material tipo Skybox/Panoramic para aplicar el fondo del espacio, para su implementación fue necesario modificar en la pestaña de Lighting el Environment para que fuera posible visualizarla.

+ Por último, en la creación del sol, se utilizó de igual manera que en los planetas la herramienta de Shader Graph, con la implementación de los componentes extras de la herramienta de visual effects, la cual se descargó por medio del package mánager de unity, la cual nos brindó efectos de partículas, las cuales se añadieron sobre nuestro shader logrando así un efecto más realista y trabajado.

+ **Video demostración**: 
Link de la nasa: https://solarsystem.nasa.gov/planets/overview/

## Preview
+ **Sol**
![](Sol.png)
+ **Mercurio**
![](Mercurio.png)
+ **Venus**
![](Venus.png)
+ **Tierra**
![](Tierra.png)
+ **Marte**
![](Marte.png)
+ **Jupiter**
![](Jupiter.png)
+ **Saturno**
![](Saturno.png)
+ **Urano**
![](Urano.png)
+ **Neptuno**
![](Neptuno.png)

+ ***Video***: https://www.youtube.com/watch?v=LrEfcYgYtwk

## Conclusión
Este proyecto resulto ser algo muy divertido por hacer, represento algo no tan fácil pero tampoco fue tan difícil, los conocimientos que teníamos fueron bastante aplicados en el proyecto y realmente disfrutamos realizándolo como equipo ya que fue algo que nos ayudó bastante a reforzar conocimientos y a buscar nuevas herramientas para futuros proyectos. 

***Integrantes***
+ Aguilar Romo Danna Paulina.
+ Amaya Quintero Cesar Heberto.
+ Delgadillo Bojórquez Marisela.
+ Peña Hernández Azalia.
