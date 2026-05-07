Este es la respuesta de chatgpt por este enunciado:
Quiero que me crees una propuesta de estructura POO, que yo implementaré en unity,
dime las clases que hay, que atributos tienen, publicas y privadas. Alguno de los objetos
debería referenciar a objetos de otro tipo. Como pasa en un inventario con los objetos de
tipo item. Haz una propuesta de ejemplo, que no sea de inventario, relacionada con
videojuegos, lo más original y divertida que puedas. Sencillo: , de 3 clases maximo y dos o
tres atributos por clase.

--------------------------------------

Aquí tienes una propuesta sencilla, original y fácil de llevar a Unity. La idea: **un sistema de “mascotas mágicas que generan caos climático”** 🌪️🐸

---

## 🧩 Concepto

El jugador tiene criaturas llamadas **Climabichos** que provocan efectos en el entorno (lluvia, viento, rayos). Cada criatura tiene un **estado emocional** que modifica su poder. Esto crea situaciones impredecibles y divertidas.

---

## 🧱 Clases (máx. 3)

### 1. `Climabicho`

Representa a la criatura principal.

**Atributos:**

* `public string nombre;`
* `private int energia;`
* `public EstadoEmocional estado;` ← referencia a otra clase

---

### 2. `EstadoEmocional`

Define cómo se siente el Climabicho y cómo afecta sus poderes.

**Atributos:**

* `public string tipo;` (Ej: "Feliz", "Enfadado", "Triste")
* `private float multiplicadorPoder;`
* `public string efectoVisual;` (Ej: "chispas", "nube oscura")

---

### 3. `EventoClimatico`

Representa el efecto que ocurre en el mundo.

**Atributos:**

* `public string tipoEvento;` (Ej: "Tormenta", "Arcoíris", "Ventisca")
* `public Climabicho origen;` ← referencia al Climabicho que lo generó
* `private float duracion;`

---

## 🔗 Relaciones clave

* `Climabicho` → tiene un → `EstadoEmocional`
* `EventoClimatico` → referencia al → `Climabicho` que lo creó

---

## 💡 Ejemplo de dinámica

* Un Climabicho “enfadado” (estado) tiene mayor multiplicador de poder.
* Genera un `EventoClimatico` más intenso (tormenta fuerte).
* Si está “feliz”, quizá genera arcoíris con buffs positivos.

---

## 🎮 Por qué funciona bien en Unity

* Puedes hacer `Climabicho` como `MonoBehaviour`
* `EstadoEmocional` podría ser un `ScriptableObject` reutilizable
* `EventoClimatico` puede instanciar efectos visuales (VFX)

---

Si quieres, puedo darte cómo se vería el código base en C# listo para Unity.
