# Учебная программа

Программа движется от спецификации и доказательства к структурам, алгоритмам, инженерии и исследованию. Она адаптивна: диагностика меняет глубину и число упражнений, но не удаляет фундаментальные зависимости. Для перехода между крупными этапами нужны глава, самостоятельная реализация/задача и контрольная точка. Уровни задач: L0 — термины, L1 — прямое применение, L2 — распознавание, L3 — комбинация, L4 — самостоятельный вывод, L5 — исследование/проект.

## 1. Фундамент алгоритмического мышления

**Темы:** модель вычислений; алгоритм; вход, выход и спецификация; предусловия и постусловия; абстракции и АТД; инварианты; частичная/полная корректность и завершаемость; детерминизм; прямое доказательство, индукция, от противного и контрпример; базовая дискретная математика, комбинаторика и рекуррентности.

**Результат:** формализовать задачу, отделять контракт от реализации, строить инвариант и опровергать неверное утверждение минимальным примером. **Контроль:** спецификация, трассировка, доказательство цикла и разбор некорректного рассуждения.

## 2. Анализ сложности

**Темы:** размер входа; время и память; лучший, средний, худший и амортизированный случаи; `O`, `Ω`, `Θ`, `o`, `ω`; функции роста, логарифмы, суммы; подстановка, дерево рекурсии, Master theorem; ограничения асимптотики; константы, выделения, локальность, CPU cache и branch prediction.

**Результат:** выводить, а не угадывать стоимость, учитывать строки, LINQ, копирование и стек. **Контроль:** анализ нескольких реализаций и эксперимент масштабирования.

## 3. Массивы и строки

**Темы:** статические/динамические, многомерные и jagged-массивы; ёмкость и амортизация; строки, Unicode в .NET; `Span<T>`, `Memory<T>`, срезы; prefix sums, difference arrays и 2D-prefix; in-place преобразования, компактификация и перестановки.

**Практика:** generic dynamic array, диапазонные суммы, Unicode-граничные случаи. **Контроль:** контракт, тесты и сравнение с `List<T>`.

## 4. Связные структуры

Одно-, дву- и циклические списки; sentinel nodes; вставка/удаление; разворот и слияние; цикл и алгоритм Флойда; skip list обзорно; сравнение со сплошной памятью. Практика: generic list с итератором и инвариантами.

## 5. Стеки, очереди и деки

Стек, очередь, кольцевой буфер, дек; монотонные стек/очередь; очередь с приоритетом как мост к кучам; парсинг, выражения, обходы и потоки. Практика: circular queue и задача с самостоятельным выбором структуры.

## 6. Хеширование

Хеш-функции и коллизии; chaining; open addressing, linear/quadratic/double probing; load factor, resize, tombstones; hash flooding; `HashSet`, `Dictionary` и внутренности .NET; составные ключи, memoization, rolling hash; Bloom filter обзорно. Практика: hash map, adversarial и differential tests.

## 7. Деревья

Терминология; binary trees; recursive/iterative DFS и BFS; BST, удаление, predecessor/successor; высота и вырождение; AVL и red-black; B/B+; trie/radix; expression trees; сериализация и LCA. Практика: BST с доказанными инвариантами; балансировка — отдельный модуль.

## 8. Кучи и очереди с приоритетом

Min/max binary heap; sift operations; linear-time heapify; heap sort; priority queue; indexed и d-ary heap; устройство binomial/Fibonacci heaps; `.NET PriorityQueue`. Практика: generic heap, тесты перестановок операций и benchmark.

## 9. Сортировки

Стабильность, in-place и адаптивность; selection, insertion, bubble как модель, Shell, merge, quick (pivot, Lomuto/Hoare), heap, counting, radix, bucket; Timsort, introsort; нижняя граница сравнений; multi-key, компараторы и .NET; external sort.

**Контроль:** выбрать алгоритм по ограничениям, доказать корректность, проверить permutation+order properties и сравнить масштабирование.

## 10. Поиск

Linear/binary search; полуинтервалы и границы; lower/upper bound; first/last; binary search on answer; применимость ternary search; quickselect, k-th statistic и median. Практика: единый контракт границ и adversarial tests.

## 11. Рекурсия и поиск с возвратом

Стек вызовов, база и переход; tail recursion; рекурсия против итерации; subsets, permutations, combinations; N-Queens, Sudoku; pruning, branch-and-bound и размер пространства. Контроль: доказательство рекурсивной корректности и оценка дерева поиска.

## 12. Алгоритмические паттерны

Two pointers, sliding window, fast/slow; prefix/difference; hash lookup; sort-and-scan; sweep line, intervals; binary search on answer; monotonic structures; frequency counting; top K и k-way merge; meet-in-the-middle; coordinate compression; offline/event processing; divide/decrease/transform-and-conquer; memoization/tabulation; bitmasks/state compression; small-to-large, sqrt decomposition, randomization.

Каждый паттерн изучается через условия применимости, вывод, контрпример, ошибки, альтернативы и задачи L1–L4; название смешанной задачи не раскрывает паттерн.

## 13. Графы

Модели (matrix/list/edges), directed/undirected/weighted; DFS/BFS, components, bipartite, cycles, topological sort; SCC (Kosaraju/Tarjan), bridges/articulation; Euler paths, Hamilton complexity; shortest paths: BFS, 0-1 BFS, Dijkstra, Bellman–Ford, Floyd–Warshall, Johnson; MST: Kruskal/Prim+DSU; flows: Ford–Fulkerson, Edmonds–Karp, Dinic, min-cut; matching: Kuhn, Hopcroft–Karp, Hungarian.

## 14. Жадные алгоритмы

Greedy choice и optimal substructure; exchange proof; интервалы, scheduling, Huffman, graph greedy; matroids вводно; систематическое построение контрпримеров неверным стратегиям.

## 15. Динамическое программирование

State, transition, base, order, answer reconstruction; memoization/tabulation; 1D/2D, strings/sequences; knapsack, LIS, LCS, edit distance; interval/tree/DAG/digit/bitmask/profile/probability DP; optimizations: divide-and-conquer, Knuth, CHT; Aliens trick обзорно. Практика начинается с вывода состояния, а не шаблона кода.

## 16. Строковые алгоритмы

Naive search; prefix function/KMP; Z; rolling hash/Rabin–Karp; trie/Aho–Corasick; suffix array+LCP; suffix tree концептуально, suffix automaton; Manacher; edit distance; repeats и periods; Unicode и выбор единицы текста.

## 17. Структуры диапазонных запросов

Prefix sums; sparse table; Fenwick; segment tree и lazy propagation; segment tree beats; merge-sort/persistent segment/wavelet trees; sqrt decomposition и Mo. Выбор структуры по изменяемости, типу операции и алгебраическим свойствам.

## 18. Система непересекающихся множеств

Quick find/union; union by rank/size; path compression и амортизация; графовые применения; rollback и persistent DSU. Практика: инварианты представителя и differential tests.

## 19. Продвинутые деревья

Treap/implicit treap; splay; order-statistic и interval trees; Cartesian tree; HLD, centroid decomposition; link-cut tree специализированно.

## 20. Продвинутые графы

LCA и binary lifting; HLD/centroid; minimum arborescence; dominators; flow optimizations, min-cost flow и circulation; 2-SAT; DAG techniques; decompositions и dynamic graphs.

## 21. Вычислительная геометрия

Points/vectors; dot/cross; orientation; segment intersection и distances; polygons, area, point-in-polygon; convex hull (Graham/Andrew), rotating calipers, sweep line, closest pair; точность, overflow и численная устойчивость.

## 22. Теория чисел

GCD, Euclid/extgcd; primes, sieve, factorization; modular arithmetic, fast power, inverse, CRT, Euler phi; primality, Miller–Rabin, Pollard rho; modular combinatorics.

## 23. Рандомизированные алгоритмы

Las Vegas/Monte Carlo; randomized quicksort/select; hash randomization; reservoir sampling; randomized structures и вероятностный анализ. Требуется формулировать вероятность ошибки и воспроизводимые тесты.

## 24. Приближённые алгоритмы и эвристики

P/NP/NP-complete и редукции на необходимом уровне; approximation guarantees; local search и greedy heuristics; simulated annealing; genetic algorithms концептуально; критерии, когда эвристика обоснована.

## 25. Параллельные алгоритмы

Data/task parallelism; races и false sharing; parallel sort/reduce; concurrent collections, PLINQ, TPL, `Channel<T>`; Amdahl/Gustafson; корректность, детерминизм и измерение ускорения.

## 26. Алгоритмы внешней памяти

I/O model; external merge sort; B-trees и LSM; данные больше RAM; memory-mapped files и streaming. Проект: сортировка/индексация с ограниченным бюджетом памяти.

## 27. Online- и streaming-алгоритмы

Online model и competitive ratio; reservoir sampling; Count-Min Sketch, HyperLogLog, Bloom filter; streaming windows, heavy hitters и approximate counting; ошибка и память как часть контракта.

## 28. Algorithm Engineering

Теория против практики; profiling и benchmark design; warm-up, JIT/tiering; allocations, cache, branches, SIMD; `Span<T>`, `ArrayPool<T>`, pooling; unsafe только с доказанной ценностью; реальные распределения и оптимизация структуры данных.

## 29. Внутреннее устройство .NET

`Array`, `List`, `LinkedList`, `Dictionary`, `HashSet`, `Queue`, `Stack`, `PriorityQueue`, sorted/immutable/concurrent collections; equality/comparison; `IEnumerable`/iterators; LINQ costs; allocations, boxing, generics, value/reference types и GC. Практика: чтение исходников runtime и benchmark гипотез.

## 30. Исследовательские и специализированные темы

Направление выбирается после классического ядра: compilers, OS, databases, networks, cryptography, ML/numerics, image/graphics/games/pathfinding, spatial/distributed/consensus, lock-free/persistent/succinct/cache-oblivious structures, topology/bioinformatics, IR/compression, advanced strings, online optimization или высокий уровень соревнований.

**Финал:** обзор литературы и реализаций, воспроизводимый эксперимент, собственное решение/улучшение, анализ ограничений и письменная защита.

## Сквозные контрольные точки и проекты

- После этапов 1–3: спецификация, сложность, массивы; проект — базовая библиотека последовательностей.
- После 4–10: классические структуры и поиск/сортировка; проект — библиотека коллекций или визуализатор.
- После 11–15: вывод решений и комбинированная контрольная; проект — планировщик/поиск пути.
- После 16–20: строки, запросы и графы; проект — индексатор, autocomplete или graph analyzer.
- После 21–29: специализированная инженерная контрольная и проект с профилированием.

Каждая контрольная включает теорию, трассировку, сложность, поиск ошибки, реализацию, выбор алгоритма, смешанную задачу и code review. Завершение подтверждается объяснением, реализацией, доказательством, граничными случаями и переносом идеи в изменённую задачу.
