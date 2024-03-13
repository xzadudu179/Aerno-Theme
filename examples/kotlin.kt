
class TestClass(val id: Int, val name: String) {
    val num: Int = 0
}


data class TestDataClass(val name: String,val id: Int)


fun main() {
    val test1 = TestClass(1, "test")

    println("${test1.name}'s id is ${test1.id}") //id is 1


    val testData = TestDataClass("testName", 1)
    val testData2 = TestDataClass("testName", 1)
    val testData3 = TestDataClass("name2", 2)
    println(testData) // TestDataClass(name=testName, id=1)
    println(testData == testData2) // true
    println(testData == testData3) // false


    val td4 = testData.copy()
    val td5 = testData.copy(name = "TEST2")
    println(td4) // TestDataClass(name=testName, id=1)
    println(td5) // TestDataClass(name=TEST2, id=1)

    var nullable: String? = null
    println(nullable?.length ?: 0)

    val l = listOf(1, 2, 3, 4, 5);
    for (i in l) {
        println(i)
    }
}

fun test(x: Int, y: Int): Int {
    println(x + y)
    return x + y
}