/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package duarte.programacion2.finalproject.series.PnlAnualidades.controllers;

import duarte.programacion2.finalproject.series.PnlAnualidades.PnlAnualidadDiferida;

/**
 *
 * @author dell
 */
public class PnlAnualidadDiferidaController {

    private final PnlAnualidadDiferida anualidadDiferida;

    public PnlAnualidadDiferidaController(PnlAnualidadDiferida anualidadDiferida) {
        this.anualidadDiferida = anualidadDiferida;
        initComponent();
    }

    private void initComponent() {
        
    }
    
    
    private void CalcularAnualidadActionPerformed(){
        if(anualidadDiferida.getRbtnVP().isSelected()){
        
        
        }else if(anualidadDiferida.getRbtnVF().isSelected()){
        
        
        }
    
    
    }
}
