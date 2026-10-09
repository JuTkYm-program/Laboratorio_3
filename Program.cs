
            // ETAPA 1 
            Console.WriteLine("=== ETAPA 1: Exploración de arreglos unidimensionales ===");
            int[] arregloUnidimensional = { 5, 12, 8, 20, 7, 15, 3, 9, 11, 4 };
            
            Console.WriteLine("Elementos del arreglo:");
            for (int i = 0; i < arregloUnidimensional.Length; i++)
            {
                Console.Write(arregloUnidimensional[i] + " ");
            }
            Console.WriteLine();

            Console.Write("\nIngrese un nuevo valor para el tercer elemento (índice 2): ");
            arregloUnidimensional[2] = int.Parse(Console.ReadLine());
            
            Console.Write("Ingrese un número a buscar en el arreglo: ");
            int numeroBuscar = int.Parse(Console.ReadLine());
            bool existe = Array.Exists(arregloUnidimensional, element => element == numeroBuscar);
            Console.WriteLine(existe ? "El número SÍ existe en el arreglo." : "El número NO existe en el arreglo.");

             // ETAPA 2
            Console.WriteLine("\n=== ETAPA 2: Uso de arreglos bidimensionales ===");
            int[,] matriz = new int[3, 3];
            int sumaTotal = 0;

            Console.WriteLine("Ingrese los valores para la matriz 3x3:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Posición [{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                    sumaTotal += matriz[i, j];
                }
            }

            Console.WriteLine("\nMatriz ingresada:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"La suma total de los elementos de la matriz es: {sumaTotal}");

             // ETAPA 3
            Console.WriteLine("\n=== ETAPA 3: Operaciones sobre listas ===");
            List<int> listaDinamica = new List<int> { 10, 20, 30 };
            int opcion = 0;

            while (opcion != 5)
            {
                Console.WriteLine("\nMenú de Lista:");
                Console.WriteLine("1. Insertar un elemento al final");
                Console.WriteLine("2. Eliminar un elemento por posición");
                Console.WriteLine("3. Buscar un valor y mostrar su posición");
                Console.WriteLine("4. Mostrar la lista actualizada");
                Console.WriteLine("5. Continuar a la Etapa 4");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el valor a insertar: ");
                        listaDinamica.Add(int.Parse(Console.ReadLine()));
                        break;
                    case 2:
                        Console.Write("Ingrese la posición a eliminar (inicia en 0): ");
                        int pos = int.Parse(Console.ReadLine());
                        if (pos >= 0 && pos < listaDinamica.Count) listaDinamica.RemoveAt(pos);
                        else Console.WriteLine("Posición inválida.");
                        break;
                    case 3:
                        Console.Write("Ingrese el valor a buscar: ");
                        int val = int.Parse(Console.ReadLine());
                        int index = listaDinamica.IndexOf(val);
                        Console.WriteLine(index != -1 ? $"Valor encontrado en la posición {index}." : "Valor no encontrado.");
                        break;
                    case 4:
                        Console.WriteLine("Lista actual: " + string.Join(", ", listaDinamica));
                        break;
                }
            }

             // ETAPA 4
            Console.WriteLine("\n=== ETAPA 4: Aplicación de algoritmos de ordenamiento ===");
            int[] listaBurbuja = { 45, 12, 78, 4, 23, 9 };
            int[] listaSeleccion = { 45, 12, 78, 4, 23, 9 };

            Console.WriteLine("Lista original: " + string.Join(", ", listaBurbuja));

           
            for (int i = 0; i < listaBurbuja.Length - 1; i++)
            {
                for (int j = 0; j < listaBurbuja.Length - i - 1; j++)
                {
                    if (listaBurbuja[j] > listaBurbuja[j + 1])
                    {
                        int temp = listaBurbuja[j];
                        listaBurbuja[j] = listaBurbuja[j + 1];
                        listaBurbuja[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Lista ordenada con Burbuja: " + string.Join(", ", listaBurbuja));

            
            for (int i = 0; i < listaSeleccion.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < listaSeleccion.Length; j++)
                {
                    if (listaSeleccion[j] < listaSeleccion[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = listaSeleccion[minIndex];
                listaSeleccion[minIndex] = listaSeleccion[i];
                listaSeleccion[i] = temp;
            }
            Console.WriteLine("Lista ordenada con Selección: " + string.Join(", ", listaSeleccion));
            
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
