package com.example.demo.entities;

import jakarta.persistence.*;
import java.util.Date;

@Entity
@Table(name = "inventory")
public class Inventory {
    
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int invId;
    
    @ManyToOne
    @JoinColumn(name = "prod_id")
    private Product product;
    
    @ManyToOne
    @JoinColumn(name = "sh_id")
    private Shop shop;
    
    @Column(name = "quantity")
    private int quantity;
    
    @Column(name = "price", nullable = false)
    private float price;
    
    @Column(name = "discount")
    private float discount;
    
    @Column(name = "mf_date")
    @Temporal(TemporalType.DATE)
    private Date mfDate;
    
    @Column(name = "ex_date")
    @Temporal(TemporalType.DATE)
    private Date exDate;

    // Getters and Setters
}

