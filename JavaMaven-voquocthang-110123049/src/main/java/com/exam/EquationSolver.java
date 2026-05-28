package com.exam;

public class EquationSolver {

    public static String giaiPhuongTrinhBac1(double a, double b) {
        if (a == 0) {
            if (b == 0) {
                return "VSN"; // Vô số nghiệm
            } else {
                return "VN";  // Vô nghiệm
            }
        } else {
            // Trường hợp có nghiệm: x = -b/a
            double x = -b / a;
            return "CN: " + x;
        }
    }

    public static void main(String[] args) {
        System.out.println("=== Chuong trinh giai phuong trinh bac 1 ===");
    }
}