import scala.io._

object mulTable {
    def main(args: Array[String]): Unit = {
        try {
            println("set size:")
            val size : Int = StdIn.readLine().toInt
            for (i <- 1 to size){
            for (j <- 1 to i){
                printf("%d * %d = %d\t", j, i, i * j)
            }
            println()
        }
        }
        catch {
            case ex: Any => {
                println("please enter a number")
            }
        }

    }
}