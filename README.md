## IMyCloneable и ICloneable
	Используя ICloneable реализуем метод Clone, который является стандартным для всех потомков 
	класса Person, но при копировании создается копия, которая ссылается на те же классы, что 
	и оригинал, при изменении которых изменяются данные внутри копии.
	При использовании IMyCloneable и MyClone необходимо переопределять метод MyClone для 
	каждого потомка, но при его использовании создается не только копия оригинала, но так 
	же копия классов на которые он ссылается и изменения в оригинальных ссылках не меняют
	полученную копию
