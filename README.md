# Examen
Programa de Ingeniería de Software  en Videojuegos.

Por favor, especifica tu nombre completo: Rubén Andrés Cimma
¿C# permite herencia múltiple? No, una clase no puede heredar de múltiples clases. Con interfaces si se puede usar herencia múltiple.

¿Cuándo utilizaría una Clase Abstracta en lugar de una Interfaz? Ejemplifique.
Se usa una clase abstracta cuando se está modelando una jerarquía de clases, donde las subclases son "un tipo de" la clase padre. Ej: Perro es un tipo de animal.
En cambio, las interfaces "se comportan como" esa interfaz.
Ej: El perro se comporta como un animal.

¿Qué implica una relación de Generalización entre dos clases?
Implica que una clase hereda de otra de esta forma. Helicóptero(Hijo) es un tipo de Vehículo(Padre).

¿Qué implica una relación de Implementación entre una clase y una interfaz?
Es como un "contrato", la clase debe implementar los métodos que se indiquen dentro de la interfaz.

¿Qué diferencia hay entre la relación de Composición y la Agregación?
La diferencia es que si en la Composición eliminamos una de las clases, la otra no podría seguir existiendo. EJ: Empresa y Empleado, si la empresa no existiera, dejaria de existir el empleado.
En cambio en la relación de Agregación no pasaria esto.

Indique V o F según corresponda. Diferencia entre Asociación y Agregación:
Una diferencia es que la segunda indica la relación entre un “todo” y sus “partes”, mientras que en la primera los objetos están al mismo nivel contextual. V
Una diferencia es que la Agregación es de cardinalidad 1 a muchos mientras que la Asociación es de 1 a 1. V
Una diferencia es que, en la Agregación, la vida o existencia de los objetos relacionados está fuertemente ligada, es decir que si “muere” el objeto contenedor también morirán las “partes”, en cambio en la Asociación los objetos viven y existen independientemente de la relación. F

