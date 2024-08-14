package com.example.demo.entities;

import jakarta.persistence.*;

@Entity
@Table(name = "products")
public class Product {
    
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int prodId;
    
    @Column(name = "prodname", nullable = false)
    private String prodname;
    
    @Column(name = "desc")
    private String desc;
    
    @ManyToOne
    @JoinColumn(name = "cat_id")
    private Category category;
    
    @ManyToOne
    @JoinColumn(name = "b_id")
    private Brand brand;

    // Getters and Setters
}

