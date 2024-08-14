package com.example.demo.entities;

import jakarta.persistence.*;

@Entity
@Table(name = "brand")
public class Brand {
    
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int bId;
    
    @Column(name = "bname", nullable = false)
    private String bname;

    // Getters and Setters
}

