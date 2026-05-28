package com.exam;

import static org.junit.Assert.assertEquals;
import org.junit.Test;

public class EquationSolverTest {

    // Trường hợp 1: Có nghiệm (CN)
    @Test
    public void testCoNghiem() {
        // 2x - 4 = 0 => x = 2.0
        String result = EquationSolver.giaiPhuongTrinhBac1(2, -4); 
        assertEquals("CN: 2.0", result);
    }

    // Trường hợp 2: Vô số nghiệm (VSN)
    @Test
    public void testVoSoNghiem() {
        // 0x + 0 = 0
        String result = EquationSolver.giaiPhuongTrinhBac1(0, 0); 
        assertEquals("VSN", result);
    }

    // Trường hợp 3: Vô nghiệm (VN)
    @Test
    public void testVoNghiem() {
        // 0x + 5 = 0
        String result = EquationSolver.giaiPhuongTrinhBac1(0, 5); 
        assertEquals("VN", result);
    }
}