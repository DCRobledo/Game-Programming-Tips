# Game Programming Tips

¡Bienvenido al repositorio de los hilos de programación de videojuegos! Aquí encontrarás el código de ejemplo relacionado con los hilos semanales sobre programación de videojuegos que he publicado en mi perfil de Twitter [@dc_robledo](https://twitter.com/dc_robledo/status/1585927495890587648).

## ¿Qué son los hilos?

Los hilos de programación de videojuegos son publicaciones semanales en las que comparto información, consejos y ejemplos prácticos sobre programación de videojuegos. Cada hilo se enfoca en un tema específico y proporciona código de ejemplo para ayudarte a comprender y aplicar los conceptos discutidos.

## Codigo de los hilos

En este repositorio, encontrarás ejemplos de código relacionados con los siguientes temas:

### 1\. [Patrón de Diseño Command](https://twitter.com/dc_robledo/status/1581194225655611394)

> **El patrón de diseño Command es un patrón de comportamiento que encapsula una solicitud como un objeto, lo que te permite parametrizar los clientes con diferentes solicitudes, encolar u operar con las solicitudes y soportar operaciones de deshacer.**
-   **¿Cuándo es útil?**: Es útil cuando se necesita desacoplar las acciones del objeto que las realiza, permitir la ejecución y deshacer de acciones, manejar las entradas del usuario y comunicarse con sistemas de IA de manera flexible.
- **Ejemplo proporcionado**: Implementación del movimiento del jugador y de un enemigo, ambos con inputs distintos.


### 2\. [Patrón de Diseño Strategy](https://twitter.com/dc_robledo/status/1586267648920281091)

> **El patrón de diseño Strategy permite definir una familia de algoritmos, encapsular cada uno como un objeto y hacer que sean intercambiables. Esto permite que el algoritmo utilizado pueda ser seleccionado en tiempo de ejecución según las necesidades del juego.**
-   **¿Cuándo es útil?**: Es útil cuando se necesita cambiar dinámicamente el comportamiento de un objeto en tiempo de ejecución, por ejemplo, para diferentes estrategias de movimiento, inteligencia artificial o sistema de combate.
- **Ejemplo proporcionado**: Implementación de un enemigo con comportamiento dinamico, cambiando entre ataques a meele y ataques de rango.

### 3\. [Patrón de Diseño Object Pooling](https://twitter.com/dc_robledo/status/1588819455328518144)

> **El patrón de diseño Object Pooling se utiliza para reutilizar y administrar un conjunto de objetos pre-creados en lugar de crear y destruirlos dinámicamente. Esto permite ahorrar recursos de creación y recolección de basura, lo que es especialmente útil para la gestión eficiente de entidades del juego que se crean y destruyen frecuentemente.**
-   **¿Cuándo es útil?**: Es útil cuando se necesitan crear y destruir objetos frecuentemente, como balas, enemigos o partículas, y se desea mejorar el rendimiento y la eficiencia del juego.
- **Ejemplo proporcionado**: Implementación de activación y desactivación de una mecanica de lanzamiento de bolas de fuego, similar a la de Super Mario.

### 4\. [Patrón de Diseño State](https://twitter.com/dc_robledo/status/1593892386333396992)

> **El patrón de diseño State permite que un objeto cambie su comportamiento en función de su estado interno. Define una interfaz común para diferentes estados y permite la transición suave entre ellos. Esto es útil cuando un objeto tiene diferentes comportamientos dependiendo de su estado actual, como un personaje que tiene diferentes acciones en los estados de "correr", "saltar" o "atacar".**
-   **¿Cuándo es útil?**: Es útil cuando se necesita gestionar estados complejos en un juego, como el estado de un personaje, la fase de juego actual o el estado de una máquina de estados finitos.
- **Ejemplo proporcionado**: Implementación de la mecanica de cambios de estado de los fantasmas de Pac-Man.

### 5\. [Patrón de Diseño Decorator](https://twitter.com/dc_robledo/status/1601515444145426433)

> **El patrón de diseño Decorator permite agregar nuevas funcionalidades a un objeto existente dinámicamente, envolviéndolo en un objeto decorador. Esto permite extender la funcionalidad de los objetos de forma flexible y modular, sin necesidad de cambiar la estructura del código existente.**
-   **¿Cuándo es útil?**: Es útil cuando se necesita añadir funcionalidad adicional a un objeto sin alterar su estructura base. Por ejemplo, se puede utilizar para agregar características a un personaje, como habilidades especiales o modificadores temporales.
- **Ejemplo proporcionado**: Implementación de una mecanica de vestido de enemigos, similar a los Mobs con armadura en Minecraft.

### 6\. [Patrón de Diseño Factory](https://twitter.com/dc_robledo/status/1609474101961162753)

> **El patrón de diseño Factory proporciona una interfaz para crear objetos, pero permite que las subclases decidan qué clase instanciar. Esto permite encapsular la lógica de creación de objetos y facilita la adición de nuevas clases de productos sin modificar el código existente.**
-   **¿Cuándo es útil?**: Es útil cuando se necesita crear objetos de diferentes tipos en tiempo de ejecución y se desea desacoplar la lógica de creación de objetos del código que los utiliza.
- **Ejemplo proporcionado**: Implementación de un spawn de enemigos dinamico en función del estado de la partida, empezando con enemigos faciles y terminando con dificiles.

### 7\. [Patrón de Diseño Bridge](https://twitter.com/dc_robledo/status/1611669340742377472)

> **El patrón de diseño Bridge separa una abstracción de su implementación, permitiendo que ambos evolucionen de forma independiente. Esto facilita la combinación de diferentes abstracciones y implementaciones, lo que es útil cuando se desea tener múltiples variaciones de un objeto y se quiere evitar una explosión de clases.**
-   **¿Cuándo es útil?**: Es útil cuando se necesita manejar múltiples variaciones de un objeto y se desea evitar la dependencia directa entre la abstracción y su implementación.
- **Ejemplo proporcionado**: Implementación de un sistema de control de NPCs aliados y sus comportamientos, similar al de The Outer Worlds.

### 8\. [Patrón de Diseño Service Locator](https://twitter.com/dc_robledo/status/1614209169296343040)

> **El patrón de diseño Service Locator proporciona una forma de obtener servicios o componentes sin tener una dependencia directa sobre ellos. Esto permite desacoplar el código que utiliza los servicios del código que los implementa, lo que facilita la modificación y reemplazo de servicios sin afectar el resto del código.**
-   **¿Cuándo es útil?**: Es útil cuando se necesita desacoplar las dependencias entre componentes y se desea tener un mecanismo centralizado para acceder a los servicios o componentes necesarios.
- **Ejemplo proporcionado**: Implementación de un servicio de audio centralizado en el juego.

### 9\. [Patrón de Diseño Prototype](https://twitter.com/dc_robledo/status/1617095075204415488)

> **El patrón de diseño Prototype se utiliza para crear nuevos objetos a partir de un prototipo existente. Permite crear copias exactas o modificadas de un objeto sin tener que conocer su clase concreta. Esto es útil cuando se quiere evitar la duplicación de código y se desea crear nuevos objetos a partir de uno existente de manera eficiente.**
-   **¿Cuándo es útil?**: Es útil cuando se necesitan crear objetos similares a otros existentes, ya sea copiando exactamente el estado del objeto original o realizando modificaciones en la copia.
- **Ejemplo proporcionado**: Implementación de un spawner de enemigos, similar a los de Minecraft.

### 10\. [Patrón de Diseño Facade](https://twitter.com/dc_robledo/status/1627231066502168577)

> **El patrón de diseño Facade proporciona una interfaz simplificada para un subsistema complejo. Actúa como un punto de entrada único para acceder a las funcionalidades del subsistema, ocultando su complejidad interna y facilitando su uso. Esto es útil cuando se quiere proporcionar una interfaz más fácil de usar y entender para un conjunto de componentes o sistemas.**
-   **¿Cuándo es útil?**: Es útil cuando se necesita simplificar la interacción con un subsistema complejo y se desea proporcionar una interfaz más intuitiva y accesible.
- **Ejemplo proporcionado**: Implementación de un sistema de transición entre gameplay de exploración y gameplay de batalla, similar al de Pokemon.

### 11\. [Patrón de Diseño Monostate](https://twitter.com/dc_robledo/status/1639910613513060355)

> **El patrón de diseño Monostate garantiza que todas las instancias de una clase compartan el mismo estado, aunque se creen múltiples instancias. Esto permite que las instancias sean intercambiables sin afectar su comportamiento. Aunque cada instancia tiene su propio estado, todas comparten y reflejan el mismo estado global.**
-   **¿Cuándo es útil?**: Es útil cuando se desea que todas las instancias de una clase compartan la misma información y estado, pero se necesita la capacidad de crear múltiples instancias independientes.
- **Ejemplo proporcionado**: Implementación de un sistema de control centralizado de las estadisticas del jugador.

### 12\. [Patrón de Diseño Observer](https://twitter.com/dc_robledo/status/1644961916064870400)

> **El patrón de diseño Observer establece una relación de uno a muchos entre un objeto (sujeto) y varios objetos dependientes (observadores). Cuando el sujeto cambia su estado, notifica y actualiza automáticamente a los observadores. Esto permite la comunicación y la sincronización entre diferentes partes del juego.**
-   **¿Cuándo es útil?**: Es útil cuando se necesita mantener un estado consistente entre diferentes objetos y se desea que los cambios en un objeto se reflejen automáticamente en otros objetos relacionados.
- **Ejemplo proporcionado**: Implementación del sistema de comunicación entre la muerte de los enemigos y la representación en la interfaz del juego.

### 13\. [Patrón de Diseño Builder](https://twitter.com/dc_robledo/status/1647509681995231232)

> **El patrón de diseño Builder se utiliza para construir objetos complejos paso a paso. Proporciona una interfaz flexible y separada para la creación de diferentes partes del objeto y la construcción final. Esto facilita la creación de objetos complejos con diferentes configuraciones sin necesidad de tener un constructor con muchos parámetros.**
-   **¿Cuándo es útil?**: Es útil cuando se necesita crear objetos complejos con diferentes configuraciones y se desea separar la construcción del objeto de su representación final.
- **Ejemplo proporcionado**: Implementación de un sistema de creación y duplicado de personajes, similar al de Elden Ring.

### 14\. [Patrón de Diseño Humble Object](https://twitter.com/dc_robledo/status/1662738053218140160)

> **El patrón de diseño Humble Object se utiliza para separar y aislar la lógica de negocio y las reglas del juego del código que maneja las interacciones con elementos externos o dependencias difíciles de probar, como la entrada/salida o la interfaz gráfica. Esto facilita las pruebas unitarias y mejora la modularidad y mantenibilidad del código.**
-   **¿Cuándo es útil?**: Es útil cuando se desea separar y aislar la lógica del juego y las reglas del negocio del código que maneja las interacciones con elementos externos o dependencias complejas de probar.
- **Ejemplo proporcionado**: Implementación de un sistema de movimiento 2D, con sus correspondientes tests unitarios.

### 15\. [Extensions Functions](https://twitter.com/dc_robledo/status/1650046409004007426)

> **Las extension functions en C# permiten agregar nuevos métodos a tipos existentes sin modificar su código fuente. Esto se logra mediante la creación de métodos estáticos que actúan como si fueran parte de la clase original. Estos métodos adicionales pueden ser invocados como si fueran métodos de instancia, lo que facilita la ampliación de funcionalidades de los tipos existentes.**
- **Ejemplo proporcionado**: Implementación de extension functions sobre el Transform de un GameObject.

### 16\. [Legibilidad de Código](https://twitter.com/dc_robledo/status/1655119846328213506)

> **La legibilidad de código se refiere a la facilidad con la que un humano puede entender y comprender el código fuente. Se logra mediante la aplicación de buenas prácticas de estilo, estructura y documentación, con el objetivo de que el código sea claro, conciso y fácil de seguir. Una buena legibilidad facilita el mantenimiento, la depuración y la colaboración en el desarrollo de software.**
- **Ejemplo proporcionado**: Mejora de la legibilidad de un sistema de movimiento, dash y disparo de projectile Top-Down.

### 17\. [Principios SOLID](https://twitter.com/dc_robledo/status/1667802338831024129)

> **Los principios SOLID son un conjunto de principios de diseño de software que promueven la creación de código limpio y modular. S: Principio de responsabilidad única. O: Principio de abierto/cerrado. L: Principio de sustitución de Liskov. I: Principio de segregación de interfaces. D: Principio de inversión de dependencia. Estos principios fomentan la cohesión, la modularidad, la reusabilidad y la mantenibilidad del código, permitiendo una arquitectura flexible y fácil de extender.**
- **Ejemplo proporcionado**: Aplicación de cada uno de los principios SOLID a un sistema de movimiento, salto y dash 2D.

### 18\. [Programación procedural](https://twitter.com/dc_robledo/status/1670364300026814465)

> **La programación de videojuegos procedural es un enfoque que utiliza algoritmos y reglas para generar contenido de forma automática, como niveles, terrenos y personajes. Esto permite crear mundos y experiencias únicas y dinámicas en los juegos, sin necesidad de diseñarlos manualmente.**
- **Ejemplo proporcionado**: Generación de un mapa 2D con tres biomas, usando la programación procedural.

### 19\. [Sistema de guardado](https://twitter.com/dc_robledo/status/1672876864568799233)

> **Los sistemas de guardado en la programación de videojuegos son herramientas que permiten a los jugadores almacenar y cargar su progreso en el juego. Estos sistemas guardan información como la ubicación del jugador, los elementos obtenidos y los logros desbloqueados, para que puedan retomar el juego desde donde lo dejaron en sesiones futuras.**
- **Ejemplo proporcionado**: Sistema de guardado de estadisticas del jugador usando serialización binaria.

### 20\. [Level Streaming](https://twitter.com/dc_robledo/status/1675413569544806403)

> **El level straming es una técnica en la que se carga y descarga el contenido de manera dinámica mientras el jugador avanza en el juego. La idea es que solamente esté cargado lo que el jugador ve.**
- **Ejemplo proporcionado**: Sistema de level streaming basado en la carga aditiva asincrona.

### 21\. [Parallel Computing](https://twitter.com/dc_robledo/status/1685560944540205056)

> **El Parallel Computing es una técnica que divide las tareas en subprocesos para ejecutarlas simultáneamente en múltiples núcleos o unidades de procesamiento llamdas hilos, mejorando así el rendimiento.**
- **Ejemplo proporcionado**: Paralelización del sumatorio de numeros usando varios hilos.

### 22\. [Behavior Trees](https://twitter.com/dc_robledo/status/1693171101868622231)

> **Los Behavior Trees son una herramienta que nos permite generar comportamientos de Inteligencias Artificiales de una forma visual y flexible.**
- **Ejemplo proporcionado**: Implementación de una IA acompañante.

### 24\. [Programación Orientada a Objectos](https://twitter.com/dc_robledo/status/1698244524223471873)

> **La Programación Orientada a Objectos (POO) es un paradigma que se basa en dividir la jerarquia de un juego en elementos simples, de forma que el conjunto sea modular, flexible y entendible.**
- **Ejemplo proporcionado**: Ejemplificación de los conceptos fundamentales de la POO (Clases y Objetos, Encapsulación, Herencia y Polimorfismo).

### XX\. [Lambdas en Unreal Engine]()

> **Las lambdas son trozos de codigo que hacen cosas concretas sin ser declaradas. Son utiles para implementar funciones anonimas que se usan una sola vez**
- **Ejemplo proporcionado**: Implementación de un actor que se esconde automaticamente.

### XX\. [Timers en Unreal Engine]()

> **Los timers son la forma que tiene Unreal de lanzar rutinas personalizadas. Estas permiten ejecutar codigo en bucle o despues de un tiempo concreto.**
- **Ejemplo proporcionado**: Implementación de un powerup de invencibilidad.

### XX\. [Delegados en Unreal Engine]()

> **Los delegados son una implementación del patrón observer dentro de Unreal Engine. La idea es conectar un observador a un notificador y cuando el estado de este último cambie, tambien cambien los observadores.**
- **Ejemplo proporcionado**: Implementación de un sistema de puntuación al matar enemigos.

### XX\. [Animation Blueprints]()

> **Los animation blueprint son una forma visual y escalable de implementar la gestión de animaciones dentro de Unreal Engine. Con ellos podemos definir maquinas de estado, transiciones y modificaciones dinamicas del personaje que la contenga.**
- **Ejemplo proporcionado**: Implementación de un movimiento en tercera persona basico.

### XX\. [Colisiones en Unreal Engine]()

> **Las colisiones en Unreal Engine se basan en tipos, respuestas y canales. La idea es tener control total sobre que y como detecta colisiones**
- **Ejemplo proporcionado**: Ejemplos de todos los tipos y respuestas posibles.


¡No dudes en explorar los ejemplos de código proporcionados en este repositorio y seguirme en [Twitter](https://twitter.com/dc_robledo) para obtener más hilos semanales de programación y diseño de videojuegos. Si tienes alguna pregunta o sugerencia, no dudes en contactarme.