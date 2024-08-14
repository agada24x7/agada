package com.example.demo.entities;

import jakarta.persistence.*;

@Entity
@Table(name = "category")
public class Category {
    
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int catId;
    
    @Column(name = "catname", nullable = false)
    private String catname;

    // Getters and Setters
}
